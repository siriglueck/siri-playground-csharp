namespace UName
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
            BtnName = new Button();
            BtnEnde = new Button();
            LblName = new Label();
            SuspendLayout();
            // 
            // BtnName
            // 
            BtnName.Location = new Point(25, 51);
            BtnName.Name = "BtnName";
            BtnName.Size = new Size(89, 23);
            BtnName.TabIndex = 0;
            BtnName.Text = "Mein Name";
            BtnName.UseVisualStyleBackColor = true;
            BtnName.Click += BtnName_Click;
            // 
            // BtnEnde
            // 
            BtnEnde.Location = new Point(163, 51);
            BtnEnde.Name = "BtnEnde";
            BtnEnde.Size = new Size(75, 23);
            BtnEnde.TabIndex = 1;
            BtnEnde.Text = "Ende";
            BtnEnde.UseVisualStyleBackColor = true;
            BtnEnde.Click += BtnEnde_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblName.Location = new Point(25, 21);
            LblName.Name = "LblName";
            LblName.Size = new Size(132, 15);
            LblName.TabIndex = 2;
            LblName.Text = "Hallo!, wie heißen Sie?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 101);
            Controls.Add(LblName);
            Controls.Add(BtnEnde);
            Controls.Add(BtnName);
            Name = "Form1";
            Text = "Mein Name";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnName;
        private Button BtnEnde;
        private Label LblName;
    }
}
