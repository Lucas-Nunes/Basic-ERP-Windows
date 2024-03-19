namespace Basic_ERP_Windows
{
    public partial class uPrincipal : Form
    {
        public uPrincipal()
        {
            InitializeComponent();
        }

        private void uPrincipal_Load(object sender, EventArgs e)
        {
            uLogin FrLogin = new uLogin();
            FrLogin.ShowDialog();
            if (string.IsNullOrWhiteSpace(uFuncoes.NomeUsuario))
            {
                this.Close();
            }
            
        }
    }
}
