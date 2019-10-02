namespace Mockup
{
    partial class CashierForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPizzas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lvControl = new System.Windows.Forms.ListView();
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conveyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isReady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPizza
            // 
            this.cbPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPizzas.FormattingEnabled = true;
            this.cbPizzas.Items.AddRange(new object[] {
            "Pepperoni",
            "Margherita",
            "Quattro Formaggi",
            "Americana",
            "Vegetariana",
            "Frutti di Mare",
            "Napoletana",
            "Mediterranea"});
            this.cbPizzas.Location = new System.Drawing.Point(9, 55);
            this.cbPizzas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPizzas.Name = "cbPizza";
            this.cbPizzas.Size = new System.Drawing.Size(435, 21);
            this.cbPizzas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the pizza:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 329);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 26);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(9, 150);
            this.tbRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(435, 20);
            this.tbRequest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Special requests:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(393, 312);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(124, 43);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNumber,
            this.conveyer,
            this.isReady,
            this.cold});
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(534, 55);
            this.lvControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(498, 301);
            this.lvControl.TabIndex = 6;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // orderNumber
            // 
            this.orderNumber.Text = "Order Number";
            this.orderNumber.Width = 76;
            // 
            // conveyer
            // 
            this.conveyer.Text = "Is order in oven?";
            this.conveyer.Width = 89;
            // 
            // isReady
            // 
            this.isReady.Text = "Is order ready?";
            this.isReady.Width = 77;
            // 
            // cold
            // 
            this.cold.Text = "Is order cold?";
            this.cold.Width = 57;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(9, 204);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(435, 95);
            this.lbOrder.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(456, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 113);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cbSize
            // 
            this.cbSize.BackColor = System.Drawing.SystemColors.Window;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XL"});
            this.cbSize.Location = new System.Drawing.Point(352, 80);
            this.cbSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(92, 21);
            this.cbSize.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pizza Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your order:";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(975, 10);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(56, 34);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(449, 204);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 41);
            this.btnRemoveItem.TabIndex = 15;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 370);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvControl);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPizzas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCashier";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrder;
        public System.Windows.Forms.TextBox tbRequest;
        public System.Windows.Forms.ComboBox cbPizzas;
        private System.Windows.Forms.ColumnHeader orderNumber;
        private System.Windows.Forms.ColumnHeader isReady;
        public System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader conveyer;
        private System.Windows.Forms.ColumnHeader cold;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox lbOrder;
        public System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

