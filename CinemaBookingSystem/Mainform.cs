//Julian Blair 131025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bioprogram
{
    public partial class Mainform : Form 
    {
        private SeatManager Mymanager;

        /// <summary>
        /// calls the methods below
        /// </summary>
        public Mainform()
        {
            InitializeComponent();
            Mymanager = new SeatManager(240);
            UpdateGUI();
        }

        /// <summary>
        /// event handler method below coordinates what happens when OK click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Click(object sender, EventArgs e)
        {
            string name = uName.Text.Trim();
            double price = 0;
            //Check if something is selected in listBox
            //If not show error message
            if (lstReservation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select seat.", "Error");
                return;
            }

            //checks if reserve seat is selected
            if (resv.Checked == true)
            {
                //Checks if name is valid. If not show error message
                if (uName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Enter name (cannot include numbers!)", "Error");
                    return;
                }
                //Checks if price is valid. If not shower error message
                if (!InputUtility.GetDouble(Price.Text, out price))
                {
                    MessageBox.Show("Enter price!", "Error");
                    return;
                }
                //Checks if position in index is already reserved, if not shows error message.
                if (!Mymanager.reserve(lstReservation.SelectedIndex, price, name))
                {
                    MessageBox.Show("Already booked choose another seat.", "Error");
                    return;
                }
            }

            else
            {
                //checks if position to be cancelled is free, if not show error message.
                if (Mymanager.isSeatFree(lstReservation.SelectedIndex))
                {
                    MessageBox.Show("Cannot cancel vacant seat!", "Select reserved seat");
                }
                Mymanager.unbook(lstReservation.SelectedIndex);
            }
            UpdateGUI();
        }
        
        /// <summary>
        /// Controls for radiobuttons switches uName and Price boxes from enabled and disabled accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resv_CheckedChanged(object sender, EventArgs e)
        {
            uName.Enabled = true;
            Price.Enabled = true;
        }

        private void CResv_CheckedChanged(object sender, EventArgs e)
        {
            uName.Enabled = false;
            Price.Enabled = false;
        }

        //Clears lstReservation and then updates by passing the method GetText through the loop below. Then updates labels accordingly
        private void UpdateGUI()
        {
            lstReservation.Items.Clear();
            for (int i = 0; i < Mymanager.NumberOfSeats(); i++)
            {
                lstReservation.Items.Add(Mymanager.GetText(i));
            }
            
            //update numbers labels
            noResv.Text = Mymanager.GetNumReserved().ToString();
            noSeat.Text = Mymanager.NumberOfSeats().ToString();
            vacSeat.Text = Mymanager.GetNumVacant().ToString();
        }
    }
}
