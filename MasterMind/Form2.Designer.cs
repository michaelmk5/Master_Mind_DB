namespace MasterMind
{
    partial class Start
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
            this.btn_nuova = new System.Windows.Forms.Button();
            this.btn_stat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nuova
            // 
            this.btn_nuova.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nuova.Font = new System.Drawing.Font("Comic Sans MS", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_nuova.Location = new System.Drawing.Point(49, 65);
            this.btn_nuova.Name = "btn_nuova";
            this.btn_nuova.Size = new System.Drawing.Size(361, 65);
            this.btn_nuova.TabIndex = 0;
            this.btn_nuova.Text = "Nuova Partita";
            this.btn_nuova.UseVisualStyleBackColor = false;
            this.btn_nuova.Click += new System.EventHandler(this.btn_nuova_Click);
            // 
            // btn_stat
            // 
            this.btn_stat.Font = new System.Drawing.Font("Comic Sans MS", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_stat.Location = new System.Drawing.Point(49, 151);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Size = new System.Drawing.Size(361, 65);
            this.btn_stat.TabIndex = 1;
            this.btn_stat.Text = "Statistiche";
            this.btn_stat.UseVisualStyleBackColor = true;
            this.btn_stat.Click += new System.EventHandler(this.btn_stat_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btn_stat);
            this.Controls.Add(this.btn_nuova);
            this.Name = "Start";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_nuova;
        private Button btn_stat;
    }
}