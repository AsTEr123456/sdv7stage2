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
    public partial class frmGames : Form
    {

        private clsCatergory _Catergory = new clsCatergory();
        private static Dictionary<String, frmGames> _GamesFormList =
            new Dictionary<String, frmGames>(); // 

        public frmGames()
        {
            InitializeComponent();
        }

        public static void Run(string prCatergoryName)
        {
            frmGames lcGameForm;
            if (string.IsNullOrEmpty(prCatergoryName) ||
            !_GamesFormList.TryGetValue(prCatergoryName, out lcGameForm))
            {
                lcGameForm = new frmGames();
                _GamesFormList.Add(prCatergoryName, lcGameForm);
                lcGameForm.SetDetails(prCatergoryName);
            }
            else
            {
                lcGameForm.Show();
                lcGameForm.UpdateDisplay();
                lcGameForm.Activate();
            }
        }

        public void SetDetails(string prCatergory)
        {
            _Catergory.Name = prCatergory;
            UpdateDisplay();
            Show();
        }

        private async void UpdateDisplay()
        {
            lbGames.DataSource = null;
            lbGames.DataSource = await clsServiceCalls.GetCategoryGamesAsync(_Catergory.Name);
        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGames.Items.Count > 0)
            {
                clsGame lcGame = lbGames.SelectedItem as clsGame;
                if (lcGame != null)
                {
                    string lcInfo = "Game Details:" +
                        "\nName: " + lcGame.Name +
                        "\nCategory: " + lcGame.Catergory +
                        "\nType: " + lcGame.Type +
                        "\nStock: " + lcGame.Stock.ToString() +
                        "\nPrice: " + lcGame.Price.ToString();
                    if (lcGame.Type == "disc")
                    {
                        lcInfo = lcInfo + "\nWeight: " + lcGame.Weight.ToString() +
                        "\nShipping: " + lcGame.Shipping.ToString();
                    }
                    else
                    {
                        lcInfo = lcInfo + "\nSerial: " + lcGame.Serial +
                        "\nDownload: " + lcGame.Download;
                    }
                    lblGameInfo.Text = lcInfo;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain.Instance.UpdateDisplay();
            Hide();
        }

        private void lbGames_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmDetails.DispatchGameForm(lbGames.SelectedValue as clsGame);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string lcReply = cmbType.Text;
            if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
            {
                clsGame lcGame = clsGame.NewWork(lcReply);
                if (lcGame != null) // valid artwork created?
                {
                    lcGame.Catergory = _Catergory.Name;
                    frmDetails.DispatchGameForm(lcGame);
                    if (!string.IsNullOrEmpty(lcGame.Name)) // not cancelled?
                    {
                        UpdateDisplay();
                        frmMain.Instance.UpdateDisplay();
                    }
                }
            }
        }

        private async void btnDeleteGame_Click(object sender, EventArgs e)
        {
            int lcIndex = lbGames.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGame lcGame = lbGames.SelectedItem as clsGame;
                MessageBox.Show(await clsServiceCalls.DeleteGameAsync(lcGame.Id.ToString()));
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private async void tmrUpdate_Tick(object sender, EventArgs e)
        {
            ListBox lcList = new ListBox();
            lcList.DataSource = await clsServiceCalls.GetCategoryGamesAsync(_Catergory.Name);
            if (lcList.Items.Count != lbGames.Items.Count)
                UpdateDisplay();
        }
    }
}
