using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cash
{
    public partial class Form1 : Form
    {
        static int BankCash = 100;

        Guy Joe = new Guy("Joe", 50);
        Guy Bob = new Guy("Bob", 100);


        public Form1()
        {
            InitializeComponent();
        }

        public void ActualizaForm()
        {
            lblJoeCash.Text = Joe.getName() +" tiene "+ Joe.getCash()+ " euros";
            lblBobCash.Text = Bob.getName() + " tiene " + Bob.getCash() + " euros";
            lblBankCash.Text = "En el banco quedan " + BankCash + " euros";

        }

        
        public static void main(String[] args)
        {
           Form1 miFormulario = new Form1();
        }


        private void btnJoeReceiveCash_Click(object sender, EventArgs e)
        {
            if (BankCash >= 10)
            {
                BankCash = BankCash - 10;
                Joe.setCash(Joe.getCash() + 10);
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("El banco no puede pasarle 10 euros a Joe");
            }
        }

        private void btnBobGiveJoe_Click(object sender, EventArgs e)
        {

        }

        private void btnBobGiveCash_Click(object sender, EventArgs e)
        {
            if (Bob.Cash >= 5)
            {

                Bob.Cash-= 5;
                BankCash= BankCash + 5;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("Bob no puede pasar 5 euros al banco");
            }

        }
    }
}