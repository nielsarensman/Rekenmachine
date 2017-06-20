namespace WindowsFormsApp1
{
    partial class Rekenmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rekenmachine));
            this.Rekensom1 = new System.Windows.Forms.TextBox();
            this.Uitwerking = new System.Windows.Forms.TextBox();
            this.Reken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rekensom3 = new System.Windows.Forms.TextBox();
            this.Rekensom2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rekensom1
            // 
            this.Rekensom1.BackColor = System.Drawing.Color.Black;
            this.Rekensom1.ForeColor = System.Drawing.Color.Lime;
            this.Rekensom1.Location = new System.Drawing.Point(32, 57);
            this.Rekensom1.Name = "Rekensom1";
            this.Rekensom1.Size = new System.Drawing.Size(219, 20);
            this.Rekensom1.TabIndex = 0;
            // 
            // Uitwerking
            // 
            this.Uitwerking.Location = new System.Drawing.Point(32, 219);
            this.Uitwerking.Name = "Uitwerking";
            this.Uitwerking.ReadOnly = true;
            this.Uitwerking.Size = new System.Drawing.Size(219, 20);
            this.Uitwerking.TabIndex = 4;
            // 
            // Reken
            // 
            this.Reken.Location = new System.Drawing.Point(32, 134);
            this.Reken.Name = "Reken";
            this.Reken.Size = new System.Drawing.Size(219, 23);
            this.Reken.TabIndex = 3;
            this.Reken.Text = "Reken Uit";
            this.Reken.UseVisualStyleBackColor = true;
            this.Reken.Click += new System.EventHandler(this.Reken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rekensom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uitwerking";
            // 
            // Rekensom3
            // 
            this.Rekensom3.BackColor = System.Drawing.Color.Black;
            this.Rekensom3.ForeColor = System.Drawing.Color.Lime;
            this.Rekensom3.Location = new System.Drawing.Point(32, 108);
            this.Rekensom3.Name = "Rekensom3";
            this.Rekensom3.Size = new System.Drawing.Size(219, 20);
            this.Rekensom3.TabIndex = 2;
            // 
            // Rekensom2
            // 
            this.Rekensom2.BackColor = System.Drawing.Color.Black;
            this.Rekensom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Rekensom2.ForeColor = System.Drawing.Color.Red;
            this.Rekensom2.Location = new System.Drawing.Point(89, 80);
            this.Rekensom2.MaxLength = 1;
            this.Rekensom2.Name = "Rekensom2";
            this.Rekensom2.Size = new System.Drawing.Size(23, 21);
            this.Rekensom2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "+, -, : of x";
            // 
            // Rekenmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rekensom2);
            this.Controls.Add(this.Rekensom3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reken);
            this.Controls.Add(this.Uitwerking);
            this.Controls.Add(this.Rekensom1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Rekenmachine";
            this.Text = "Rekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Rekensom1;
        private System.Windows.Forms.TextBox Uitwerking;
        private System.Windows.Forms.Button Reken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rekensom3;
        private System.Windows.Forms.TextBox Rekensom2;
        private System.Windows.Forms.Label label3;
    }
}

