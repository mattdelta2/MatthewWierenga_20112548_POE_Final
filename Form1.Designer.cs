
namespace MatthewWierenga_20112548_POE
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMap = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(481, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(584, 124);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(38, 15);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "label1";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(1011, 35);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(38, 15);
            this.Info.TabIndex = 2;
            this.Info.Text = "label1";
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Location = new System.Drawing.Point(1011, 226);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(38, 15);
            this.lblEnemies.TabIndex = 3;
            this.lblEnemies.Text = "label1";
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(155, 81);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(38, 15);
            this.lblShop.TabIndex = 4;
            this.lblShop.Text = "label1";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(584, 400);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.lblEnemies);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Button btnPurchase;
    }
}

