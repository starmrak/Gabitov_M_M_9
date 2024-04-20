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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            string username = tbLogin.Text;
            string password = tbPassword.Text;
            try
            {
                List<User> users = auction_gabitovEntities1.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.UserName == username && p.Password == password);
                if (u != null)
                {
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            items items = new items();
            items.Show();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont cont = new cont();
            cont.Show();
        }
    }
}
