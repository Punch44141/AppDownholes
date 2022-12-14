using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace AppDownholes
{
    public partial class MainForm : Form
    {

        private SQLiteConnection DBConnection = null;

        private SQLiteCommandBuilder BuilderDownholes = null;

        private SQLiteDataAdapter DataAdapterDownholes = null;

        private DataSet dataSetDownholes = null;

        private bool newRowAdding = false;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void LoadData()
        {
            try
            {
                DataAdapterDownholes = new SQLiteDataAdapter("SELECT *, 'Delete' AS [Command] FROM [Table]", DBConnection);

                BuilderDownholes = new SQLiteCommandBuilder(DataAdapterDownholes);

                BuilderDownholes.GetInsertCommand();
                BuilderDownholes.GetUpdateCommand();
                BuilderDownholes.GetDeleteCommand();

                dataSetDownholes = new DataSet();

                DataAdapterDownholes.Fill(dataSetDownholes, "Table");

                dataGridView1.DataSource = dataSetDownholes.Tables["Table"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[14, i] = linkCell;
                }

                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[12].Width = 120;
                dataGridView1.Columns[13].Width = 150;
                dataGridView1.Columns[14].Width = 80;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSetDownholes.Tables["Table"].Clear();

                DataAdapterDownholes.Fill(dataSetDownholes, "Table");

                dataGridView1.DataSource = dataSetDownholes.Tables["Table"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[14, i] = linkCell;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBConnection = new SQLiteConnection("Data Source=DownholesDB.db;Version=3");

            DBConnection.Open();

            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex==14)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataSetDownholes.Tables["Table"].Rows[rowIndex].Delete();

                            DataAdapterDownholes.Update(dataSetDownholes, "Table");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSetDownholes.Tables["Table"].NewRow();

                        row["Дата"] = dataGridView1.Rows[rowIndex].Cells["Дата"].Value;
                        row["Месторождение"] = dataGridView1.Rows[rowIndex].Cells["Месторождение"].Value;
                        row["Куст"] = dataGridView1.Rows[rowIndex].Cells["Куст"].Value;
                        row["Номер скважины"] = dataGridView1.Rows[rowIndex].Cells["Номер скважины"].Value;
                        row["Тип прибора"] = dataGridView1.Rows[rowIndex].Cells["Тип прибора"].Value;
                        row["Метод исследования"] = dataGridView1.Rows[rowIndex].Cells["Метод исследования"].Value;
                        row["Номер прибора"] = dataGridView1.Rows[rowIndex].Cells["Номер прибора"].Value;
                        row["Недропользователь"] = dataGridView1.Rows[rowIndex].Cells["Недропользователь"].Value;
                        row["Заказчик"] = dataGridView1.Rows[rowIndex].Cells["Заказчик"].Value;
                        row["Подрядчик"] = dataGridView1.Rows[rowIndex].Cells["Подрядчик"].Value;
                        row["Начальник партии"] = dataGridView1.Rows[rowIndex].Cells["Начальник партии"].Value;
                        row["Расположение файлов"] = dataGridView1.Rows[rowIndex].Cells["Расположение файлов"].Value;
                        row["Дополнительная информация"] = dataGridView1.Rows[rowIndex].Cells["Дополнительная информация"].Value;

                        dataSetDownholes.Tables["Table"].Rows.Add(row);

                        dataSetDownholes.Tables["Table"].Rows.RemoveAt(dataSetDownholes.Tables["Table"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[14].Value = "Delete";

                        DataAdapterDownholes.Update(dataSetDownholes, "Table");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSetDownholes.Tables["Table"].Rows[r]["Дата"] = dataGridView1.Rows[r].Cells["Дата"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Месторождение"] = dataGridView1.Rows[r].Cells["Месторождение"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Куст"] = dataGridView1.Rows[r].Cells["Куст"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Номер скважины"] = dataGridView1.Rows[r].Cells["Номер скважины"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Тип прибора"] = dataGridView1.Rows[r].Cells["Тип прибора"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Метод исследования"] = dataGridView1.Rows[r].Cells["Метод исследования"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Номер прибора"] = dataGridView1.Rows[r].Cells["Номер прибора"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Недропользователь"] = dataGridView1.Rows[r].Cells["Недропользователь"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Заказчик"] = dataGridView1.Rows[r].Cells["Заказчик"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Подрядчик"] = dataGridView1.Rows[r].Cells["Подрядчик"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Начальник партии"] = dataGridView1.Rows[r].Cells["Начальник партии"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Расположение файлов"] = dataGridView1.Rows[r].Cells["Расположение файлов"].Value;
                        dataSetDownholes.Tables["Table"].Rows[r]["Дополнительная информация"] = dataGridView1.Rows[r].Cells["Дополнительная информация"].Value;

                        DataAdapterDownholes.Update(dataSetDownholes, "Table");

                        dataGridView1.Rows[e.RowIndex].Cells[14].Value = "Delete";
                    }
                    ReloadData();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[14, lastRow] = linkCell;

                    row.Cells["Command"].Value = "Insert";

                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[14, rowIndex] = linkCell;

                    editingRow.Cells["Command"].Value = "Update";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 3|| dataGridView1.CurrentCell.ColumnIndex == 4|| dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxNumberDownhole.Text !="" || textBoxMine.Text !="")
            {
                textBoxResultSearch.Clear();

                SQLiteCommand searchCommand = DBConnection.CreateCommand();
                searchCommand.CommandText = $"SELECT * FROM [Table] WHERE [Месторождение] LIKE '%{textBoxMine.Text}%' AND [Номер скважины] LIKE '%{textBoxNumberDownhole.Text}%'";              

                SQLiteDataReader dataReader = searchCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                            textBoxResultSearch.Text += 
                            "Номер скважины: " + dataReader["Номер скважины"] + 
                            "   Месторождение: " + dataReader["Месторождение"] +
                            "   Тип прибора: " + dataReader["Тип прибора"] + 
                            "   Дата: " + dataReader["Дата"] + 
                            "   Метод: " + dataReader["Метод исследования"] + "\r\n";
                    }
                }
                else
                {
                    textBoxResultSearch.Text = "Не найдено!";
                }
            }
            else
            {
                textBoxResultSearch.Text = "Параметры не заданы!";
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxResultSearch.Clear();
            textBoxNumberDownhole.Clear();
            textBoxMine.Clear();
        }
       
        

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            textBoxFindStatistics.Clear();

            SQLiteCommand allrowsCommand = DBConnection.CreateCommand();
            allrowsCommand.CommandText = $"SELECT COUNT (*) FROM [Table]";
            double allrows = Convert.ToDouble(allrowsCommand.ExecuteScalar());
            

            if (comboBoxStatistics.Text != "" && textBoxStatistics.Text != "")
            {
                SQLiteCommand statisticsCommand = DBConnection.CreateCommand();
                statisticsCommand.CommandText = $"SELECT * FROM [Table] WHERE [{comboBoxStatistics.Text}] LIKE '%{textBoxStatistics.Text}%'";

                double result = 0;
                                                               
                SQLiteDataReader dataReader = statisticsCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    textBoxFindStatistics.Text += "Даты исследований:" + "\r\n";

                    while (dataReader.Read())
                    {
                        textBoxFindStatistics.Text +=dataReader["Дата"] + "\r\n";       
                        result++;
                    }

                    string percent = string.Format("{0:P}", result / allrows);
                    textBoxFindStatistics.Text += "Скважины исследовались " + result + " раз" + "\r\n" + 
                        "Исследований с данным значенем " + percent;
                }
                else
                {
                    textBoxFindStatistics.Text = "Не найдено!";
                }

            }

            else
            {
                textBoxFindStatistics.Text = "Параметры не заданы!";
            }
        }

        private void buttonClearStatistics_Click(object sender, EventArgs e)
        {
            textBoxFindStatistics.Clear();
            textBoxStatistics.Clear();
        }
    }
}
