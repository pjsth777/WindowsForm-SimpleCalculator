
using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // Declare controls and variables
        TextBox txtDisplay;
        Button btnOne, btnTwo, btnThree, btnFour, btnFive, btnSix, btnSeven, btnEight, btnNine, btnZero;
        Button btnAdd, btnSubtract, btnMultiply, btnDivide, btnEqual, btnClear;
        double result = 0;
        string operatorUsed = "";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new TextBox();
            this.btnOne = new Button();
            this.btnTwo = new Button();
            this.btnThree = new Button();
            this.btnFour = new Button();
            this.btnFive = new Button();
            this.btnSix = new Button();
            this.btnSeven = new Button();
            this.btnEight = new Button();
            this.btnNine = new Button();
            this.btnZero = new Button();
            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnMultiply = new Button();
            this.btnDivide = new Button();
            this.btnEqual = new Button();
            this.btnClear = new Button();


            // Configure UI Layout
            this.SuspendLayout();
            ConfigureLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeUI()
        {
            // Add the controls to the form
            this.Controls.Add(txtDisplay);
            this.Controls.Add(btnOne);
            this.Controls.Add(btnTwo);
            this.Controls.Add(btnThree);
            this.Controls.Add(btnFour);
            this.Controls.Add(btnFive);
            this.Controls.Add(btnSix);
            this.Controls.Add(btnSeven);
            this.Controls.Add(btnEight);
            this.Controls.Add(btnNine);
            this.Controls.Add(btnZero);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSubtract);
            this.Controls.Add(btnMultiply);
            this.Controls.Add(btnDivide);
            this.Controls.Add(btnEqual);
            this.Controls.Add(btnClear);

            // Assign event handlers to buttons
            btnOne.Click += Btn_Click;
            btnTwo.Click += Btn_Click;
            btnThree.Click += Btn_Click;
            btnFour.Click += Btn_Click;
            btnFive.Click += Btn_Click;
            btnSix.Click += Btn_Click;
            btnSeven.Click += Btn_Click;
            btnEight.Click += Btn_Click;
            btnNine.Click += Btn_Click;
            btnZero.Click += Btn_Click;
            
            btnAdd.Click += Operator_Click;
            btnSubtract.Click += Operator_Click;
            btnMultiply.Click += Operator_Click;
            btnDivide.Click += Operator_Click;
            btnEqual.Click += BtnEqual_Click;
            btnClear.Click += BtnEqual_Click;
        }

        // Configure Layout for buttons and display
        private void ConfigureLayout()
        {
            // Configure the TextBox for display
            txtDisplay.ReadOnly = true;
            txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtDisplay.Location = new System.Drawing.Point(12, 12);
            txtDisplay.Size = new System.Drawing.Size(260, 35);
            txtDisplay.TextAlign = HorizontalAlignment.Right;

            // Position buttons on the form
            btnOne.Text = "1"; btnOne.Location = new System.Drawing.Point(12, 60); btnOne.Size = new System.Drawing.Size(50, 50);
            btnTwo.Text = "2"; btnTwo.Location = new System.Drawing.Point(68, 60); btnTwo.Size = new System.Drawing.Size(50, 50);
            btnThree.Text = "3"; btnThree.Location = new System.Drawing.Point(124, 60); btnThree.Size = new System.Drawing.Size(50, 50);
            btnAdd.Text = "+"; btnAdd.Location = new System.Drawing.Point(180, 60); btnAdd.Size = new System.Drawing.Size(50, 50);
            
            btnFour.Text = "4"; btnFour.Location = new System.Drawing.Point(12, 116); btnFour.Size = new System.Drawing.Size(50, 50);
            btnFive.Text = "5"; btnFive.Location = new System.Drawing.Point(68, 116); btnFive.Size = new System.Drawing.Size(50, 50);
            btnSix.Text = "6"; btnSix.Location = new System.Drawing.Point(124, 116); btnSix.Size = new System.Drawing.Size(50, 50);
            btnSubtract.Text = "-"; btnSubtract.Location = new System.Drawing.Point(180, 116); btnSubtract.Size = new System.Drawing.Size(50, 50);
            
            btnSeven.Text = "7"; btnSeven.Location = new System.Drawing.Point(12, 172); btnSeven.Size = new System.Drawing.Size(50, 50);
            btnEight.Text = "8"; btnEight.Location = new System.Drawing.Point(68, 172); btnEight.Size = new System.Drawing.Size(50, 50);
            btnNine.Text = "9"; btnNine.Location = new System.Drawing.Point(124, 172); btnNine.Size = new System.Drawing.Size(50, 50);
            btnMultiply.Text = "*"; btnMultiply.Location = new System.Drawing.Point(180, 172); btnMultiply.Size = new System.Drawing.Size(50, 50);
            
            btnZero.Text = "0"; btnZero.Location = new System.Drawing.Point(12, 228); btnZero.Size = new System.Drawing.Size(50, 50);
            btnEqual.Text = "="; btnEqual.Location = new System.Drawing.Point(60, 228); btnEqual.Size = new System.Drawing.Size(106, 50);
            btnClear.Text = "C"; btnClear.Location = new System.Drawing.Point(180, 228); btnClear.Size = new System.Drawing.Size(50, 50);
            btnDivide.Text = "/"; btnDivide.Location = new System.Drawing.Point(180, 2284); btnDivide.Size = new System.Drawing.Size(50, 50);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Clear();
            }

            isOperatorClicked = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorUsed = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperatorClicked = true;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (operatorUsed)
            {
                case "+":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operatorUsed = "";
            isOperatorClicked = false;
        }

    }

}