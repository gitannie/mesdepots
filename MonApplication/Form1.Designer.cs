namespace MonApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(37, 35);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(186, 67);
            this.BT1.TabIndex = 0;
            this.BT1.Text = "BBouton de base";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "bouton Annie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "BoutonB22";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

