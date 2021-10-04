using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace ProjectTrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void Team_Name_label_Click(object sender, EventArgs e)
        {

        }

        private void Create_prize_btn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(Place_Number_txtbx.Text,
                    Place_name_txtbx.Text,
                    Prize_Amount_txtbx.Text,
                    Prize_Percentage_txtbx.Text);

                foreach (IDataConnection item in GlobalConfig.connections)
                {
                    item.CreatePrize(prizeModel);
                }
                Place_name_txtbx.Clear();
                Place_Number_txtbx.Clear();
                Prize_Amount_txtbx.Clear();
                Prize_Percentage_txtbx.Clear();




            }
            else
            {
                MessageBox.Show("Ivalid Data Entered Are Detected,Please Try Again","ALERT!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            bool placenbvalidatednumber = int.TryParse(Place_Number_txtbx.Text, out int PlaceNumber);
            if (!placenbvalidatednumber)
            {
                output = false;
            }

            if (PlaceNumber<1)
            {
                output = false;
            }

            if (Place_name_txtbx.Text.Length==0)
            {
                output = false;
            }

            decimal prizeamount = 0;
            double prizepercentage = 0;

            bool prizeamountvalid = decimal.TryParse(Prize_Amount_txtbx.Text, out prizeamount);

            bool prizepercentagevalid = double.TryParse(Prize_Percentage_txtbx.Text, out prizepercentage);

            if (!prizeamountvalid || !prizepercentagevalid)
            {
                output = false;
            }

            if (prizeamount <= 0 && prizepercentage <=0)
            {
                output = false;
            }

            if (prizepercentage<0 || prizepercentage>100) 
            {
                output = false;
            }

            return output;
        }
    }
}
