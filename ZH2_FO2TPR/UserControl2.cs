using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_FO2TPR
{
    public partial class UserControl2 : UserControl
    {
        Models.SzallashelyContext szallashelyContext = new Models.SzallashelyContext();
        public UserControl2()
        {
            InitializeComponent();
            foglalasBindingSource.DataSource = szallashelyContext.Foglalas.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.FormClosed += Form3_FormClosed;
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            foglalasBindingSource.DataSource = szallashelyContext.Foglalas.ToList();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Models.Foglalas selectedFoglalas = (Models.Foglalas)dataGridView1.SelectedRows[0].DataBoundItem;
                try
                {
                    szallashelyContext.Foglalas.Remove(selectedFoglalas);
                    szallashelyContext.SaveChanges();
                    MessageBox.Show("A foglalás törlése sikeres!");

                    foglalasBindingSource.DataSource = szallashelyContext.Foglalas.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a foglalás törlésekor:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás a törléshez.");
            }
        }
    }
}
