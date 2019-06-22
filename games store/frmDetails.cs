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
    public partial class frmDetails : Form
    {
        protected clsGame _Game = new clsGame();

        public frmDetails()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            pushData();
            if (txtName.Enabled)
                MessageBox.Show(await clsServiceCalls.InsertGameAsync(_Game));
            else
                MessageBox.Show(await clsServiceCalls.UpdateGameAsync(_Game));
            Close();
        }

        protected virtual void updateForm()
        {
            lblCatergory.Text = _Game.Catergory;
            txtName.Text = _Game.Name;
            txtPrice.Text = _Game.Price.ToString();
            txtStock.Text = _Game.Stock.ToString();
            txtName.Enabled = string.IsNullOrEmpty(_Game.Name);
        }

        public void SetDetails(clsGame prGame)
        {
            _Game = prGame;
            updateForm();
            Show();
        }

        protected virtual void pushData()
        {
            _Game.Name = txtName.Text;
            _Game.Price = decimal.Parse(txtPrice.Text);
            _Game.Stock = int.Parse(txtStock.Text);
        }

        public delegate void LoadGameFormDelegate(clsGame prGame);

        public static Dictionary<string, Delegate> _GamesForm = new Dictionary<string, Delegate>
        {
          {"digi", new LoadGameFormDelegate(frmDigital.Run)},
          {"disc", new LoadGameFormDelegate(frmDisc.Run)},
        };


        internal static void DispatchGameForm(clsGame prGame)
        {
            _GamesForm[prGame.Type].DynamicInvoke(prGame);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
