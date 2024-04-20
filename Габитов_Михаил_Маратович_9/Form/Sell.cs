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
using Excel = Microsoft.Office.Interop.Excel;

namespace Габитов_Михаил_Маратович_9
{
    public partial class Sell : Form
    {
        int _itemcount = 0;
        public Sell()
        {
            InitializeComponent();
            LoadAndInitData();
        }
        private void LoadAndInitData()
        {
            var currentItem = auction_gabitovEntities1.GetContext().sells.Join
                (auction_gabitovEntities1.GetContext().items, p => p.id_item, t => t.id_item,
                (p, t) => new { p.id_sale, t.name_item, p.date_trade, p.start_prise, p.last_price, p.sign_sale }).ToList();
            dgvSell.DataSource = currentItem;

            dgvSell.Columns[0].HeaderText = "код продажи";
            dgvSell.Columns[1].HeaderText = "Название предмета";
            dgvSell.Columns[2].HeaderText = "дата торга";
            dgvSell.Columns[3].HeaderText = "начальная цена";
            dgvSell.Columns[4].HeaderText = "последняя цена";
            dgvSell.Columns[5].HeaderText = "признак продажи";

            _itemcount = dgvSell.Rows.Count;
        }
        private void dgvSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "продажи";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < dgvSell.Columns.Count; j++)
                    worksheet.Cells[1, i + 1] = dgvSell.Columns[j].HeaderCell.Value;
            }

            for (int i = 2; i < dgvSell.Rows.Count + 2; i++)
            {
                for (int j = 0; j < dgvSell.Columns.Count; j++)
                {
                    worksheet.Cells[i, j + 1] = dgvSell[j, i - 2].Value;
                }
            }
            application.Visible = true;
        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
    }
}
