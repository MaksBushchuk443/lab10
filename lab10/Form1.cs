using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        
        private void tsSeparator2_Click(object sender, EventArgs e)
        {

        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCar.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MarkaCar";
            column.Name = "Марка";

            gvCar.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ModelCar";
            column.Name = "Модель";

            gvCar.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "bodyTipe";
            column.Name = "Кузов";
           
            gvCar.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "engineСapacity";
            column.Name = "Об'єм";

            gvCar.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";

            gvCar.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ManufacturerCountry";
            column.Name = "Країна";
                       
            gvCar.Columns.Add(column);
            column = new
            DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Electro";
            column.Name = "Електро"; column.Width = 60;

            gvCar.Columns.Add(column);
            bindSrcCars.Add(new Car("Daewoo", "Lanos", "Седан", 1.4 , 100000 , "Україна", false));
            
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            fCar ft = new fCar(car);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcCars.Add(car);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Car car = (Car)bindSrcCars.List[bindSrcCars.Position];
            fCar ft = new fCar(car);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcCars.List[bindSrcCars.Position] = car;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcCars.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
             "Очистити таблицю?\n\nВсі дані будуть втрачені",
             "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcCars.Clear();
            }
        }
    }

}
