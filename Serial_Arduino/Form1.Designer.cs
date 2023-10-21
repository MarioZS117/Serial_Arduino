namespace Serial_Arduino
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
            btnEncender = new Button();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // btnEncender
            // 
            btnEncender.BackColor = Color.Lime;
            btnEncender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncender.Location = new Point(360, 78);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(118, 35);
            btnEncender.TabIndex = 0;
            btnEncender.Text = "ENCENDER";
            btnEncender.UseVisualStyleBackColor = false;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApagar.Location = new Point(369, 160);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(94, 31);
            btnApagar.TabIndex = 1;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagar);
            Controls.Add(btnEncender);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEncender;
        private Button btnApagar;
    }
}