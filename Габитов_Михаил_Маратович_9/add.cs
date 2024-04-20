using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Габитов_Михаил_Маратович_9.Model;

namespace Габитов_Михаил_Маратович_9
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            int a;
            sell ADD = new sell();
            if (cbPerd.SelectedIndex == 0)
            {
                a = 1;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 1)
            {
                a = 4;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 2)
            {
                a = 9;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 3)
            {
                a = 12;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 4)
            {
                a = 14;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 5)
            {
                a = 17;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 6)
            {
                a = 20;
                ADD.id_item = (a);
            }
            if (cbPerd.SelectedIndex == 7)
            {
                a = 21;
                ADD.id_item = (a);
            }
            ADD.start_prise = Convert.ToInt32(tbPL.Text);
            ADD.last_price = Convert.ToInt32(tbPS.Text);

            ADD.sign_sale = Convert.ToString(cbYN.SelectedValue);
            auction_gabitovEntities1.GetContext().sells.Add(ADD);
            auction_gabitovEntities1.GetContext().SaveChanges();
            
        }
        private void LoadAndInitData()
        {
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
