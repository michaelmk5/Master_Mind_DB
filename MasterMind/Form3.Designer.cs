namespace MasterMind
{
    partial class Statistiche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_vittorie = new System.Windows.Forms.Label();
            this.lb_sconfitte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vittorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sconfitte";
            // 
            // lb_vittorie
            // 
            this.lb_vittorie.AutoSize = true;
            this.lb_vittorie.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_vittorie.Location = new System.Drawing.Point(84, 110);
            this.lb_vittorie.Name = "lb_vittorie";
            this.lb_vittorie.Size = new System.Drawing.Size(0, 39);
            this.lb_vittorie.TabIndex = 2;
            // 
            // lb_sconfitte
            // 
            this.lb_sconfitte.AutoSize = true;
            this.lb_sconfitte.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sconfitte.Location = new System.Drawing.Point(372, 95);
            this.lb_sconfitte.Name = "lb_sconfitte";
            this.lb_sconfitte.Size = new System.Drawing.Size(0, 39);
            this.lb_sconfitte.TabIndex = 3;
            // 
            // Statistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_sconfitte);
            this.Controls.Add(this.lb_vittorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistiche";
            this.Text = "Statistiche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_vittorie;
        private Label lb_sconfitte;
    }
}