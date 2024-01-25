namespace Project1Winforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            labelToClickMe = new Label();
            incomeTextBox = new TextBox();
            labelTypeIncomes = new Label();
            totalIncomeLabel = new Label();
            addIncomeButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(12, 1);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 0;
            button1.Text = "click to know the standart deduction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelToClickMe
            // 
            labelToClickMe.AccessibleDescription = "";
            labelToClickMe.AutoSize = true;
            labelToClickMe.Location = new Point(172, 26);
            labelToClickMe.Name = "labelToClickMe";
            labelToClickMe.Size = new Size(0, 20);
            labelToClickMe.TabIndex = 1;
            // 
            // incomeTextBox
            // 
            incomeTextBox.Location = new Point(443, 62);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new Size(125, 27);
            incomeTextBox.TabIndex = 2;
            incomeTextBox.TextChanged += textBox1_TextChanged;
            incomeTextBox.KeyPress += textBoxKeyPress;
            // 
            // labelTypeIncomes
            // 
            labelTypeIncomes.AutoSize = true;
            labelTypeIncomes.BackColor = SystemColors.AppWorkspace;
            labelTypeIncomes.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelTypeIncomes.Location = new Point(436, 34);
            labelTypeIncomes.Name = "labelTypeIncomes";
            labelTypeIncomes.Size = new Size(128, 20);
            labelTypeIncomes.TabIndex = 3;
            labelTypeIncomes.Text = "Type your incomes";
            labelTypeIncomes.Click += label1_Click;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Location = new Point(493, 111);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(0, 20);
            totalIncomeLabel.TabIndex = 4;
            totalIncomeLabel.TextChanged += addIncomeButton_Click;
            // 
            // addIncomeButton
            // 
            addIncomeButton.BackColor = Color.Goldenrod;
            addIncomeButton.Location = new Point(613, 31);
            addIncomeButton.Name = "addIncomeButton";
            addIncomeButton.Size = new Size(68, 58);
            addIncomeButton.TabIndex = 5;
            addIncomeButton.Text = "Add Income";
            addIncomeButton.UseVisualStyleBackColor = false;
            addIncomeButton.Click += addIncomeButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(741, 480);
            Controls.Add(addIncomeButton);
            Controls.Add(totalIncomeLabel);
            Controls.Add(labelTypeIncomes);
            Controls.Add(incomeTextBox);
            Controls.Add(labelToClickMe);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelToClickMe;
        private TextBox incomeTextBox;
        private Label labelTypeIncomes;
        private Label totalIncomeLabel;
        private Button addIncomeButton;
    }
}