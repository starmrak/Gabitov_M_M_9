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
    public partial class items : Form
    {
        int _itemcount = 0;
        public items()
        {
            InitializeComponent();
            LoadAndInitData();
        }

        private void item_Load(object sender, EventArgs e)
        {

        }
        private void LoadAndInitData()
        {
            var currentItem = auction_gabitovEntities1.GetContext().items.Join
                (auction_gabitovEntities1.GetContext().type_item, p => p.id_type, t => t.id_type,
                (p, t) => new { p.id_item, p.name_item, p.year_release, p.owner, p.date_admission, p.Price }).ToList();
            dgvItem.DataSource = currentItem;

            dgvItem.Columns[0].HeaderText = "Код предмета";
            dgvItem.Columns[1].HeaderText = "Название предмета";
            dgvItem.Columns[2].HeaderText = "Год выпуска";
            dgvItem.Columns[3].HeaderText = "Владелец";
            dgvItem.Columns[4].HeaderText = "Дата приема";
            dgvItem.Columns[5].HeaderText = "Оценочная стоимость";

            _itemcount = dgvItem.Rows.Count;
        }
        private void UpdateData()
        {
            var currentItem = auction_gabitovEntities1.GetContext().items.Join
                (auction_gabitovEntities1.GetContext().type_item, p=> p.id_type, t => t.id_type,
                (p, t) => new { p.id_item, p.name_item, p.year_release, p.owner, p.date_admission, p.Price,t.name_type }).ToList();


                currentItem =currentItem.Where(p=>p.name_item.ToLower().Contains(tbNameItem.Text.ToLower())).ToList();

            if(cbSortTime.SelectedIndex >= 0)
            {
                if(cbSortTime.SelectedIndex == 0)
                    currentItem = currentItem.OrderBy(p=>p.year_release).ToList();
                if(cbSortTime.SelectedIndex == 1)
                    currentItem = currentItem.OrderByDescending(p=>p.year_release).ToList();
            }
            if(cbFiter.SelectedIndex >=0)
            {
                if (cbFiter.SelectedIndex == 0)
                    currentItem = currentItem.Where(t => t.name_type.ToLower().Contains(cbFiter.Text.ToLower())).ToList();
                if (cbFiter.SelectedIndex == 1)
                    currentItem = currentItem.Where(t => t.name_type.ToLower().Contains(cbFiter.Text.ToLower())).ToList();
                if (cbFiter.SelectedIndex == 2)
                    currentItem = currentItem.Where(t => t.name_type.ToLower().Contains(cbFiter.Text.ToLower())).ToList();
                if (cbFiter.SelectedIndex == 3)
                    currentItem = currentItem.Where(t => t.name_type.ToLower().Contains(cbFiter.Text.ToLower())).ToList();
            }

                dgvItem.DataSource = currentItem;
        }

        private void tbNameItem_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void cbSortTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAndInitData();
        }

        private void cbFiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
          int a;
            a = Convert.ToInt32(tbFilter.Text);
            var currentItem = auction_gabitovEntities1.GetContext().items.Join
                (auction_gabitovEntities1.GetContext().type_item, p => p.id_type, t => t.id_type,
                (p, t) => new { p.id_item, p.name_item, p.year_release, p.owner, p.date_admission, p.Price }).ToList();


            if (cbFiter.SelectedIndex < 0)
            {
                  MessageBox.Show(a + "  " + cbFilter.SelectedIndex);
                   currentItem = currentItem.Where(p => (p.Price > a)).ToList();
                  dgvItem.DataSource = currentItem;

            }
            else
            {
                  MessageBox.Show(a + "  " + cbFilter.SelectedIndex);
                 currentItem = currentItem.Where(p => (p.Price < a)).ToList();
                dgvItem.DataSource = currentItem;
            }
          //  dgvItem.DataSource = currentItem;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
        }
    }
}
