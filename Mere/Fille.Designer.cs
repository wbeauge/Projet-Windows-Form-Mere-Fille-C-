namespace Mere
{
    partial class Fille
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
            this.lbJechange = new System.Windows.Forms.Label();
            this.tbChangeNom = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJechange
            // 
            this.lbJechange.AutoSize = true;
            this.lbJechange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJechange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbJechange.Location = new System.Drawing.Point(12, 43);
            this.lbJechange.Name = "lbJechange";
            this.lbJechange.Size = new System.Drawing.Size(125, 16);
            this.lbJechange.TabIndex = 0;
            this.lbJechange.Text = "Je change de nom :";
            // 
            // tbChangeNom
            // 
            this.tbChangeNom.Location = new System.Drawing.Point(144, 38);
            this.tbChangeNom.Name = "tbChangeNom";
            this.tbChangeNom.Size = new System.Drawing.Size(100, 20);
            this.tbChangeNom.TabIndex = 1;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(250, 36);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(144, 92);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // Fille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.tbChangeNom);
            this.Controls.Add(this.lbJechange);
            this.Name = "Fille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJechange;
        private System.Windows.Forms.TextBox tbChangeNom;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}