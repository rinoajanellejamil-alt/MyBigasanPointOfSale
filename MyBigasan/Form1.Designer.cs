namespace PointOfSaleSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCustomerName = new Label();
            lblCustomerAddress = new Label();
            txtCustomerAddress = new TextBox();
            btnContinueToPOS = new Button();
            btnExit = new Button();
            txtCustomerName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSalesHistory = new Button();
            btnProductManagement = new Button();

            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 224, 192);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 109);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MyBigasan";

            // lblCustomerName
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Javanese Text", 14.25F);
            lblCustomerName.ForeColor = Color.FromArgb(128, 64, 0);
            lblCustomerName.Location = new Point(127, 163);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(152, 43);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name";

            // lblCustomerAddress
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Javanese Text", 14.25F);
            lblCustomerAddress.ForeColor = Color.FromArgb(128, 64, 0);
            lblCustomerAddress.Location = new Point(127, 201);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(86, 43);
            lblCustomerAddress.TabIndex = 2;
            lblCustomerAddress.Text = "Address";

            // txtCustomerName
            txtCustomerName.Location = new Point(307, 172);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(415, 23);
            txtCustomerName.TabIndex = 0;

            // txtCustomerAddress
            txtCustomerAddress.Location = new Point(307, 210);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(415, 23);
            txtCustomerAddress.TabIndex = 1;

            // btnContinueToPOS
            btnContinueToPOS.BackColor = Color.FromArgb(82, 152, 82);
            btnContinueToPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnContinueToPOS.ForeColor = SystemColors.ButtonHighlight;
            btnContinueToPOS.Location = new Point(294, 325);
            btnContinueToPOS.Name = "btnContinueToPOS";
            btnContinueToPOS.Size = new Size(383, 33);
            btnContinueToPOS.TabIndex = 2;
            btnContinueToPOS.Text = "CONTINUE";
            btnContinueToPOS.UseVisualStyleBackColor = false;

            // btnSalesHistory
            btnSalesHistory.BackColor = Color.FromArgb(221, 200, 77);
            btnSalesHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalesHistory.ForeColor = SystemColors.ActiveCaptionText;
            btnSalesHistory.Location = new Point(294, 364);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(383, 33);
            btnSalesHistory.TabIndex = 3;
            btnSalesHistory.Text = "SALES HISTORY";
            btnSalesHistory.UseVisualStyleBackColor = false;

            // btnProductManagement
            btnProductManagement.BackColor = Color.FromArgb(213, 204, 164);
            btnProductManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProductManagement.Location = new Point(294, 403);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(383, 33);
            btnProductManagement.TabIndex = 4;
            btnProductManagement.Text = "PRODUCT MANAGEMENT";
            btnProductManagement.UseVisualStyleBackColor = false;

            // btnExit
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(294, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(383, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;

            // flowLayoutPanel1
            flowLayoutPanel1.BackColor = Color.DarkGreen;
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Location = new Point(1, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(949, 103);
            flowLayoutPanel1.TabIndex = 6;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(947, 578);

            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerAddress);
            Controls.Add(btnContinueToPOS);
            Controls.Add(btnSalesHistory);
            Controls.Add(btnProductManagement);
            Controls.Add(btnExit);

            Name = "Form1";
            Text = "MyBigasan";

            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomerName;
        private Label lblCustomerAddress;
        private TextBox txtCustomerAddress;
        private TextBox txtCustomerName;
        private Button btnContinueToPOS;
        private Button btnExit;
        private Button btnSalesHistory;
        private Button btnProductManagement;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
