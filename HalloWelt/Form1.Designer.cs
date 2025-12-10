namespace HalloWelt
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
            LblAnzeige = new Label();
            CmdHallo = new Button();
            CmdEnde = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeige.Location = new Point(23, 28);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(36, 17);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "(leer)";
            // 
            // CmdHallo
            // 
            CmdHallo.Location = new Point(24, 69);
            CmdHallo.Name = "CmdHallo";
            CmdHallo.Size = new Size(75, 23);
            CmdHallo.TabIndex = 1;
            CmdHallo.Text = "Hallo";
            CmdHallo.UseVisualStyleBackColor = true;
            CmdHallo.Click += CmdHallo_Click;
            // 
            // CmdEnde
            // 
            CmdEnde.Location = new Point(24, 114);
            CmdEnde.Name = "CmdEnde";
            CmdEnde.Size = new Size(75, 23);
            CmdEnde.TabIndex = 2;
            CmdEnde.Text = "Ende";
            CmdEnde.UseVisualStyleBackColor = true;
            CmdEnde.Click += CmdEnde_Click;
            // 
            // button1
            // 
            button1.Location = new Point(111, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Hallo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(194, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Hallo";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CmdEnde);
            Controls.Add(CmdHallo);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Mein erstes Projekt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button CmdHallo;
        private Button CmdEnde;
        private Button button1;
        private Button button2;
    }
}
