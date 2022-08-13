namespace BugTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }

            //Validamos que se haya ingresado una contrasenia
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contrasenia...");
                return;
            }

            MessageBox.Show("Usted a ingresado al sistema correctamente.");

            //cierra el programa
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}