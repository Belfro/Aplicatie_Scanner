namespace Aplicatie_Scanner
{
    partial class Form_Dialog
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
            tbDialog = new TextBox();
            btnDialog = new Button();
            SuspendLayout();
            // 
            // tbDialog
            // 
            tbDialog.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbDialog.Location = new Point(49, 22);
            tbDialog.Name = "tbDialog";
            tbDialog.Size = new Size(178, 43);
            tbDialog.TabIndex = 0;
            // 
            // btnDialog
            // 
            btnDialog.Location = new Point(75, 91);
            btnDialog.Name = "btnDialog";
            btnDialog.Size = new Size(116, 42);
            btnDialog.TabIndex = 1;
            btnDialog.Text = "Introducere";
            btnDialog.UseVisualStyleBackColor = true;
            btnDialog.Click += btnDialog_Click;
            // 
            // Form_Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 156);
            Controls.Add(btnDialog);
            Controls.Add(tbDialog);
            Name = "Form_Dialog";
            Text = "Cantitate Lemn Foc";
            Load += Form_Dialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDialog;
        private Button btnDialog;
    }
}