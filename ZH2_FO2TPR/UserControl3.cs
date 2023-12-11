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
    public partial class UserControl3 : UserControl
    {
        Models.SzallashelyContext szallashelyContext = new Models.SzallashelyContext();
        public UserControl3()
        {
            InitializeComponent();
            vendegBindingSource.DataSource = szallashelyContext.Vendeg.ToList();
            szobaBindingSource.DataSource = szallashelyContext.Szoba.ToList();
            dataGridView1.DataSource = szallashelyContext.Foglalas.ToList();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                szallashelyContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
