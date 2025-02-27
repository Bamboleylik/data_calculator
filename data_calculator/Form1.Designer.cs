namespace data_calculator
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
            txtDate = new TextBox();
            btnCalculate = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            lblYears = new Label();
            lblMonths = new Label();
            lblDays = new Label();
            lblHours = new Label();
            lblMinutes = new Label();
            lblSeconds = new Label();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new Point(284, 30);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(230, 27);
            txtDate.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(371, 99);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(51, 56);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(636, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(636, 99);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 31);
            btnSave.TabIndex = 3;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(636, 164);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 26);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "btnLoad";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Location = new Point(199, 259);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(50, 20);
            lblYears.TabIndex = 5;
            lblYears.Text = "label1";
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Location = new Point(284, 259);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(50, 20);
            lblMonths.TabIndex = 7;
            lblMonths.Text = "label2";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(384, 259);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(50, 20);
            lblDays.TabIndex = 9;
            lblDays.Text = "label3";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(476, 259);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(50, 20);
            lblHours.TabIndex = 11;
            lblHours.Text = "label4";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(558, 259);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(50, 20);
            lblMinutes.TabIndex = 13;
            lblMinutes.Text = "label5";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Location = new Point(645, 259);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(50, 20);
            lblSeconds.TabIndex = 14;
            lblSeconds.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeconds);
            Controls.Add(lblMinutes);
            Controls.Add(lblHours);
            Controls.Add(lblDays);
            Controls.Add(lblMonths);
            Controls.Add(lblYears);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(txtDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private Button btnCalculate;
        private Button btnClose;
        private Button btnSave;
        private Button btnLoad;
        private Label lblYears;
        private Label lblMonths;
        private Label lblDays;
        private Label lblHours;
        private Label lblMinutes;
        private Label lblSeconds;
    }
}