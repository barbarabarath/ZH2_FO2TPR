using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_FO2TPR
{
    public partial class Form3 : Form
    {
        Models.SzallashelyContext SzallashelyContext = new Models.SzallashelyContext();
        public Form3()
        {
            InitializeComponent();
            foglalasBindingSource.DataSource = SzallashelyContext.Foglalas.ToList();
            var user = from x in SzallashelyContext.Vendeg
                       select x.Usernev;

            comboBoxUser.DataSource = user.ToList();

            var hotel = from x in SzallashelyContext.Szallashely

                        select x.SzallasNev;

            comboBoxHotel.DataSource = hotel.ToList();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenHotelName = comboBoxHotel.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(chosenHotelName))
            {
                var rooms = from x in SzallashelyContext.Szoba
                            where x.SzallasFkNavigation.SzallasNev == chosenHotelName
                            select x.SzobaSzama;

                comboBoxRoom.DataSource = rooms.ToList();
            }
            else
            {
                comboBoxRoom.DataSource = null;
            }

        }
        private bool CheckIfFull(string data)
        {
            return !string.IsNullOrEmpty(data);
        }

        private bool CheckIfMore(string data)
        {
            Regex r = new Regex("[0-9]");
            return r.IsMatch(data);
        }

        private void textAdult_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textAdult, "");
        }

        private void textAdult_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIfFull(textAdult.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textAdult, "A felnőttek száma mező nem lehet üres!");
            }
        }

        private void textKid_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textKid, "");
        }

        private void textKid_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIfMore(textKid.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textKid, "A mezőt kötelező számformátummal kitölteni!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DialogResult result = MessageBox.Show("Biztos hozzá szeretné adni?", "Hozzáadás", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        Models.Foglalas ujfoglalas = new Models.Foglalas()
                        {
                            UgyfelFk = comboBoxUser.Text,
                            SzobaFk = Int32.Parse(comboBoxRoom.Text),
                            Mettol = dateTimePicker1.Value,
                            Meddig = dateTimePicker2.Value,
                            FelnottSzam = Int32.Parse(textAdult.Text),
                            GyermekSzam = Int32.Parse(textKid.Text),
                        };

                        SzallashelyContext.Foglalas.Add(ujfoglalas);
                        SzallashelyContext.SaveChanges();

                        MessageBox.Show("A foglalás hozzáadása sikeres!");
                        foglalasBindingSource.DataSource = SzallashelyContext.Foglalas.ToList();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt a foglalás hozzáadásakor:\n" + ex.Message);
                    }
                }
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
