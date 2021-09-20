namespace KlasaArraylistGabrielMatosevic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoviAutoButton = new System.Windows.Forms.Button();
            this.UpperTextBox = new System.Windows.Forms.TextBox();
            this.UnesiButton = new System.Windows.Forms.Button();
            this.LowerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ObrisiListuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoviAutoButton
            // 
            this.NoviAutoButton.Location = new System.Drawing.Point(12, 12);
            this.NoviAutoButton.Name = "NoviAutoButton";
            this.NoviAutoButton.Size = new System.Drawing.Size(133, 23);
            this.NoviAutoButton.TabIndex = 0;
            this.NoviAutoButton.Text = "Novi Automobil";
            this.NoviAutoButton.UseVisualStyleBackColor = true;
            this.NoviAutoButton.Click += new System.EventHandler(this.NoviAutoButton_Click);
            // 
            // UpperTextBox
            // 
            this.UpperTextBox.Enabled = false;
            this.UpperTextBox.Location = new System.Drawing.Point(13, 42);
            this.UpperTextBox.Name = "UpperTextBox";
            this.UpperTextBox.Size = new System.Drawing.Size(189, 20);
            this.UpperTextBox.TabIndex = 1;
            // 
            // UnesiButton
            // 
            this.UnesiButton.Enabled = false;
            this.UnesiButton.Location = new System.Drawing.Point(208, 40);
            this.UnesiButton.Name = "UnesiButton";
            this.UnesiButton.Size = new System.Drawing.Size(75, 23);
            this.UnesiButton.TabIndex = 2;
            this.UnesiButton.Text = "Unesi";
            this.UnesiButton.UseVisualStyleBackColor = true;
            this.UnesiButton.Click += new System.EventHandler(this.UnesiButton_Click);
            // 
            // LowerRichTextBox
            // 
            this.LowerRichTextBox.Location = new System.Drawing.Point(13, 69);
            this.LowerRichTextBox.Name = "LowerRichTextBox";
            this.LowerRichTextBox.ReadOnly = true;
            this.LowerRichTextBox.Size = new System.Drawing.Size(270, 213);
            this.LowerRichTextBox.TabIndex = 3;
            this.LowerRichTextBox.Text = "";
            // 
            // ObrisiListuButton
            // 
            this.ObrisiListuButton.Location = new System.Drawing.Point(12, 304);
            this.ObrisiListuButton.Name = "ObrisiListuButton";
            this.ObrisiListuButton.Size = new System.Drawing.Size(133, 23);
            this.ObrisiListuButton.TabIndex = 4;
            this.ObrisiListuButton.Text = "Obrisi listu";
            this.ObrisiListuButton.UseVisualStyleBackColor = true;
            this.ObrisiListuButton.Click += new System.EventHandler(this.ObrisiListuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 355);
            this.Controls.Add(this.ObrisiListuButton);
            this.Controls.Add(this.LowerRichTextBox);
            this.Controls.Add(this.UnesiButton);
            this.Controls.Add(this.UpperTextBox);
            this.Controls.Add(this.NoviAutoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoviAutoButton;
        private System.Windows.Forms.TextBox UpperTextBox;
        private System.Windows.Forms.Button UnesiButton;
        private System.Windows.Forms.RichTextBox LowerRichTextBox;
        private System.Windows.Forms.Button ObrisiListuButton;
    }
}

