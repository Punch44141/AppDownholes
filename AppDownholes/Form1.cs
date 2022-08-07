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

        private SQLiteConnection SQLiteConnection = null;

        private SQLiteCommandBuilder SQLiteBuilder = null;

        private SQLiteDataAdapter SQLiteDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                SQLiteDataAdapter = new SQLiteDataAdapter("SELECT *, 'Delete' AS [Command] FROM [Table]", SQLiteConnection);

                SQLiteBuilder = new SQLiteCommandBuilder(SQLiteDataAdapter);

                SQLiteBuilder.GetInsertCommand();
                SQLiteBuilder.GetUpdateCommand();
                SQLiteBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                SQLiteDataAdapter.Fill(dataSet, "Table");

                dataGridView1.DataSource = dataSet.Tables["Table"];

                              
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

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Table"].Clear();

                SQLiteDataAdapter.Fill(dataSet, "Table");

                dataGridView1.DataSource = dataSet.Tables["Table"];

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
            SQLiteConnection = new SQLiteConnection("Data Source=DownholesDB.db;Version=3");

            SQLiteConnection.Open();

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

                            dataSet.Tables["Table"].Rows[rowIndex].Delete();

                            SQLiteDataAdapter.Update(dataSet,"Table");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Table"].NewRow();

                        row["Дата"] = dataGridView1.Rows[rowIndex].Cells["Дата"].Value;
                        row["Месторождение"] = dataGridView1.Rows[rowIndex].Cells["Месторождение"].Value;
                        row["Куст"] = dataGridView1.Rows[rowIndex].Cells["Куст"].Value;
                        row["Номер скважины"] = dataGridView1.Rows[rowIndex].Cells["Номер скважины"].Value;
                        row["Тип прибора"] = dataGridView1.Rows[rowIndex].Cells["Тип прибора"].Value;
                        row["Метод иследования"] = dataGridView1.Rows[rowIndex].Cells["Метод иследования"].Value;
                        row["Номер прибора"] = dataGridView1.Rows[rowIndex].Cells["Номер прибора"].Value;
                        row["Недропользователь"] = dataGridView1.Rows[rowIndex].Cells["Недропользователь"].Value;
                        row["Заказчик"] = dataGridView1.Rows[rowIndex].Cells["Заказчик"].Value;
                        row["Подрядчик"] = dataGridView1.Rows[rowIndex].Cells["Подрядчик"].Value;
                        row["Начальник партии"] = dataGridView1.Rows[rowIndex].Cells["Начальник партии"].Value;
                        row["Расположение файлов"] = dataGridView1.Rows[rowIndex].Cells["Расположение файлов"].Value;
                        row["Дополнительная информация"] = dataGridView1.Rows[rowIndex].Cells["Дополнительная информация"].Value;

                        dataSet.Tables["Table"].Rows.Add(row);

                        dataSet.Tables["Table"].Rows.RemoveAt(dataSet.Tables["Table"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[14].Value = "Delete";

                        SQLiteDataAdapter.Update(dataSet, "Table");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Table"].Rows[r]["Дата"] = dataGridView1.Rows[r].Cells["Дата"].Value;
                        dataSet.Tables["Table"].Rows[r]["Месторождение"] = dataGridView1.Rows[r].Cells["Месторождение"].Value;
                        dataSet.Tables["Table"].Rows[r]["Куст"] = dataGridView1.Rows[r].Cells["Куст"].Value;
                        dataSet.Tables["Table"].Rows[r]["Номер скважины"] = dataGridView1.Rows[r].Cells["Номер скважины"].Value;
                        dataSet.Tables["Table"].Rows[r]["Тип прибора"] = dataGridView1.Rows[r].Cells["Тип прибора"].Value;
                        dataSet.Tables["Table"].Rows[r]["Метод иследования"] = dataGridView1.Rows[r].Cells["Метод иследования"].Value;
                        dataSet.Tables["Table"].Rows[r]["Номер прибора"] = dataGridView1.Rows[r].Cells["Номер прибора"].Value;
                        dataSet.Tables["Table"].Rows[r]["Недропользователь"] = dataGridView1.Rows[r].Cells["Недропользователь"].Value;
                        dataSet.Tables["Table"].Rows[r]["Заказчик"] = dataGridView1.Rows[r].Cells["Заказчик"].Value;
                        dataSet.Tables["Table"].Rows[r]["Подрядчик"] = dataGridView1.Rows[r].Cells["Подрядчик"].Value;
                        dataSet.Tables["Table"].Rows[r]["Начальник партии"] = dataGridView1.Rows[r].Cells["Начальник партии"].Value;
                        dataSet.Tables["Table"].Rows[r]["Расположение файлов"] = dataGridView1.Rows[r].Cells["Расположение файлов"].Value;
                        dataSet.Tables["Table"].Rows[r]["Дополнительная информация"] = dataGridView1.Rows[r].Cells["Дополнительная информация"].Value;

                        SQLiteDataAdapter.Update(dataSet, "Table");

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

            if (dataGridView1.CurrentCell.ColumnIndex == 4|| dataGridView1.CurrentCell.ColumnIndex == 5|| dataGridView1.CurrentCell.ColumnIndex == 8)
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
    }
}
