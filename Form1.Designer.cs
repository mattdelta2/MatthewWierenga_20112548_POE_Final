
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
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(218, 59);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(38, 15);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "label1";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(573, 58);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(38, 15);
            this.Info.TabIndex = 2;
            this.Info.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label Info;
    }
}

