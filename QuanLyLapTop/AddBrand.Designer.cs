namespace QuanLyLapTop
{
    partial class AddBrand
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
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtAddBrand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.White;
            this.btnAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddBrand.Image = global::QuanLyLapTop.Properties.Resources.add_icon;
            this.btnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBrand.Location = new System.Drawing.Point(97, 202);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(95, 35);
            this.btnAddBrand.TabIndex = 27;
            this.btnAddBrand.Text = "Thêm";
            this.btnAddBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtAddBrand
            // 
            this.txtAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBrand.Location = new System.Drawing.Point(25, 122);
            this.txtAddBrand.Name = "txtAddBrand";
            this.txtAddBrand.Size = new System.Drawing.Size(227, 29);
            this.txtAddBrand.TabIndex = 119;
            // 
            // AddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAddBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Name = "AddBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hãng máy tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtAddBrand;
    }
}