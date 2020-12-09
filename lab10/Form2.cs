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
    
    public partial class fCar : Form
    {
        public Car TheCar;
        public fCar( Car t)
        {
            TheCar = t;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheCar.MarkaCar = tbMarkaCar.Text.Trim();
            TheCar.ModelCar = tbModelCar.Text.Trim();
            TheCar.BodyTipe = tbBodyTipe.Text.Trim();
            TheCar.EngineСapacity = double.Parse(tbEngineCapacity.Text.Trim());
            TheCar.Price = int.Parse(tbPrice.Text.Trim());
            TheCar.ManufacturerCountry = tbManufacturerCountry.Text.Trim();
            TheCar.Electro = cbhElectro.Checked;
            DialogResult = DialogResult.OK;

            AcceptButton = btnOk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void ManufacturerCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void fCar_Load(object sender, EventArgs e)
        {
            if (TheCar != null)
            {
                tbMarkaCar.Text = TheCar.MarkaCar;
                tbModelCar.Text = TheCar.ModelCar;
                tbBodyTipe.Text = TheCar.BodyTipe;
                tbEngineCapacity.Text = TheCar.EngineСapacity.ToString("0.0") ;
                tbPrice.Text = TheCar.Price.ToString();
                tbManufacturerCountry.Text = TheCar.ManufacturerCountry;
                cbhElectro.Checked = TheCar.Electro;
            }
        }
    }
}
