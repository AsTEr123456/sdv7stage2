using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace games_store
{
    public sealed partial class frmDisc : games_store.frmDetails
    {
        private static readonly frmDisc Instance = new frmDisc();

        public frmDisc()
        {
            InitializeComponent();
        }

        public static void Run(clsGame prGame)
        {
            Instance.SetDetails(prGame);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtWeight.Text = _Game.Weight.ToString();
            txtShipping.Text = _Game.Shipping.ToString();
        }

        protected override void pushData()
        {
            base.pushData();
            _Game.Weight = int.Parse(txtWeight.Text);
            _Game.Shipping = decimal.Parse(txtShipping.Text);
        }

    }
}
