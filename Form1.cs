using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cash
{
    public partial class Form1 : Form
    {
        Guy Joe;
        Guy Bob;
        int BankCash = 100;

        public Form1()
        {
            InitializeComponent();
        }

        public void ActualizaForm()
        {
            lblJoeCash.Text = Joe.Name + " tiene " + Joe.Cash + " euros";
            lblBobCash.Text = Bob.Name + " tiene " + Bob.Cash + " euros";
            lblBankCash.Text = "En el banco quedan " + BankCash + "euros";

        }
        /*
        public static void main(String[] args)
        {



            Guy Joe = new Guy();
            Joe.Name = "Joe";
            Joe.Cash = 100;
            Guy Bob = new Guy();
            Bob.Name = "Bob";
            Bob.Cash = 50;


        }
        */
        private void btnJoeReceiveCash_Click(object sender, EventArgs e)
        {
            if (BankCash > 10)
            {
                BankCash = BankCash - 10;
                Joe.Cash = Joe.Cash + 10;
                ActualizaForm();
            }
        }





    }
}