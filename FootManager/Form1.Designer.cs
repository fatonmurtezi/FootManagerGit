namespace FootManager
{
    partial class FrmLogin
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreerCompte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(26, 27);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(78, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "mot de passe";
            // 
            // lblCreerCompte
            // 
            this.lblCreerCompte.AutoSize = true;
            this.lblCreerCompte.Location = new System.Drawing.Point(206, 163);
            this.lblCreerCompte.Name = "lblCreerCompte";
            this.lblCreerCompte.Size = new System.Drawing.Size(124, 20);
            this.lblCreerCompte.TabIndex = 2;
            this.lblCreerCompte.Text = "créer un compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "mot de passe oublié";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(161, 107);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(229, 30);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(161, 21);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(229, 26);
            this.tbIdentifiant.TabIndex = 5;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(161, 62);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '*';
            this.tbMotDePasse.Size = new System.Drawing.Size(229, 26);
            this.tbMotDePasse.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 236);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCreerCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "FrmLogin";
            this.Text = "FootManager - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreerCompte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.TextBox tbMotDePasse;
    }
}

