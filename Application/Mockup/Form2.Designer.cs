namespace Mockup
{
    partial class CookForm
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
            this.lblOrderN = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lbSpecial = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbWholeOrder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOrderN
            // 
            this.lblOrderN.AutoSize = true;
            this.lblOrderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderN.Location = new System.Drawing.Point(6, 23);
            this.lblOrderN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderN.Name = "lblOrderN";
            this.lblOrderN.Size = new System.Drawing.Size(114, 17);
            this.lblOrderN.TabIndex = 2;
            this.lblOrderN.Text = "Order number:";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(244, 61);
            this.btnReady.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(152, 72);
            this.btnReady.TabIndex = 3;
            this.btnReady.Text = "Order in oven";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.BtnReady_Click);
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.Location = new System.Drawing.Point(32, 93);
            this.lblPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(0, 22);
            this.lblPizza.TabIndex = 4;
            // 
            // lbSpecial
            // 
            this.lbSpecial.AutoSize = true;
            this.lbSpecial.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbSpecial.Location = new System.Drawing.Point(32, 157);
            this.lbSpecial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpecial.Name = "lbSpecial";
            this.lbSpecial.Size = new System.Drawing.Size(0, 22);
            this.lbSpecial.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 72);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lbWholeOrder
            // 
            this.lbWholeOrder.FormattingEnabled = true;
            this.lbWholeOrder.Location = new System.Drawing.Point(9, 61);
            this.lbWholeOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbWholeOrder.Name = "lbWholeOrder";
            this.lbWholeOrder.Size = new System.Drawing.Size(217, 160);
            this.lbWholeOrder.TabIndex = 7;
            // 
            // CookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(407, 229);
            this.Controls.Add(this.lbWholeOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbSpecial);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblOrderN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CookForm";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.FrmCook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderN;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lbSpecial;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbWholeOrder;
    }
}