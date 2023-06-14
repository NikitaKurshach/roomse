using NRoomS.controller;

namespace NRoomS
{
    public partial class UIUserCard : UserControl
    {
        public UIUserCard()
        {
            InitializeComponent();
        }

        public void setUser(string user)
        {
            _login.Text = user;
        }

        private void _log_out_Click(object sender, EventArgs e)
        {
            new IniFileManager("data.ini").DeleteFile();
            Application.Restart();
        }
    }
}
