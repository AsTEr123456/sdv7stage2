using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_store
{
    public sealed partial class frmMain : Form
    {   //Singleton
        private static readonly frmMain _Instance = new frmMain();// single term

        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            lbCatergories.DataSource = null;
            lbCatergories.DataSource = await clsServiceCalls.GetGameCategoriesAsync();
            lbOrders.DataSource = null;
            lbOrders.DataSource = await clsServiceCalls.GetGameOrdersAsync();
        }

        private void lbCatergories_DoubleClick_1(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lbCatergories.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmGames.Run(lbCatergories.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            int lcIndex = lbOrders.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsOrder lcOrder= lbOrders.SelectedItem as clsOrder;
                MessageBox.Show(await clsServiceCalls.DeleteOrderAsync(lcOrder.Id.ToString()));
                Instance.UpdateDisplay();
            }
        }
    }
}
