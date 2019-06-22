using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace games_store
{
    public sealed partial class frmDigital : games_store.frmDetails
    {
        private static readonly frmDigital Instance = new frmDigital();

        public frmDigital()
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
            if (_Game.Serial != null) txtSerial.Text = _Game.Serial.ToString();
            if (_Game.Download != null) txtDownload.Text = _Game.Download.ToString();
        }

        protected override void pushData()
        {
            base.pushData();
            _Game.Serial = txtSerial.Text;
            _Game.Download = txtDownload.Text;
        }
    }
}
