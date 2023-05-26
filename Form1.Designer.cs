namespace Cash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJoeCash = new System.Windows.Forms.Label();
            this.lblBobCash = new System.Windows.Forms.Label();
            this.lblBankCash = new System.Windows.Forms.Label();
            this.btnJoeReceiveCash = new System.Windows.Forms.Button();
            this.btnBobGiveCash = new System.Windows.Forms.Button();
            this.btnJoeGiveBob = new System.Windows.Forms.Button();
            this.btnBobGiveJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoeCash
            // 
            this.lblJoeCash.AutoSize = true;
            this.lblJoeCash.Location = new System.Drawing.Point(87, 64);
            this.lblJoeCash.Name = "lblJoeCash";
            this.lblJoeCash.Size = new System.Drawing.Size(128, 20);
            this.lblJoeCash.TabIndex = 0;
            this.lblJoeCash.Text = "Joe tiene 50 euros";
            // 
            // lblBobCash
            // 
            this.lblBobCash.AutoSize = true;
            this.lblBobCash.Location = new System.Drawing.Point(87, 118);
            this.lblBobCash.Name = "lblBobCash";
            this.lblBobCash.Size = new System.Drawing.Size(141, 20);
            this.lblBobCash.TabIndex = 1;
            this.lblBobCash.Text = "Bob tiene 100 euros";
            // 
            // lblBankCash
            // 
            this.lblBankCash.AutoSize = true;
            this.lblBankCash.Location = new System.Drawing.Point(87, 172);
            this.lblBankCash.Name = "lblBankCash";
            this.lblBankCash.Size = new System.Drawing.Size(171, 20);
            this.lblBankCash.TabIndex = 2;
            this.lblBankCash.Text = "El banco tiene 100 euros";
            // 
            // btnJoeReceiveCash
            // 
            this.btnJoeReceiveCash.Location = new System.Drawing.Point(87, 231);
            this.btnJoeReceiveCash.Name = "btnJoeReceiveCash";
            this.btnJoeReceiveCash.Size = new System.Drawing.Size(134, 69);
            this.btnJoeReceiveCash.TabIndex = 3;
            this.btnJoeReceiveCash.Text = "Dar 10 euros a Joe";
            this.btnJoeReceiveCash.UseVisualStyleBackColor = true;
            this.btnJoeReceiveCash.Click += new System.EventHandler(this.btnJoeReceiveCash_Click);
            // 
            // btnBobGiveCash
            // 
            this.btnBobGiveCash.Location = new System.Drawing.Point(280, 231);
            this.btnBobGiveCash.Name = "btnBobGiveCash";
            this.btnBobGiveCash.Size = new System.Drawing.Size(132, 72);
            this.btnBobGiveCash.TabIndex = 4;
            this.btnBobGiveCash.Text = "Recibir 5 € de Bob";
            this.btnBobGiveCash.UseVisualStyleBackColor = true;
            this.btnBobGiveCash.Click += new System.EventHandler(this.btnBobGiveCash_Click);
            // 
            // btnJoeGiveBob
            // 
            this.btnJoeGiveBob.Location = new System.Drawing.Point(87, 339);
            this.btnJoeGiveBob.Name = "btnJoeGiveBob";
            this.btnJoeGiveBob.Size = new System.Drawing.Size(134, 65);
            this.btnJoeGiveBob.TabIndex = 5;
            this.btnJoeGiveBob.Text = "Joe da 10 € a Bob";
            this.btnJoeGiveBob.UseVisualStyleBackColor = true;
            this.btnJoeGiveBob.Visible = false;
            // 
            // btnBobGiveJoe
            // 
            this.btnBobGiveJoe.AllowDrop = true;
            this.btnBobGiveJoe.Location = new System.Drawing.Point(280, 339);
            this.btnBobGiveJoe.Name = "btnBobGiveJoe";
            this.btnBobGiveJoe.Size = new System.Drawing.Size(132, 65);
            this.btnBobGiveJoe.TabIndex = 6;
            this.btnBobGiveJoe.Text = "Bob da 5 € a Joe";
            this.btnBobGiveJoe.UseVisualStyleBackColor = true;
            this.btnBobGiveJoe.Visible = false;
            this.btnBobGiveJoe.Click += new System.EventHandler(this.btnBobGiveJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBobGiveJoe);
            this.Controls.Add(this.btnJoeGiveBob);
            this.Controls.Add(this.btnBobGiveCash);
            this.Controls.Add(this.btnJoeReceiveCash);
            this.Controls.Add(this.lblBankCash);
            this.Controls.Add(this.lblBobCash);
            this.Controls.Add(this.lblJoeCash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJoeCash;
        private Label lblBobCash;
        private Label lblBankCash;
        private Button btnJoeReceiveCash;
        private Button btnBobGiveCash;
        private Button btnJoeGiveBob;
        private Button btnBobGiveJoe;

    }
}