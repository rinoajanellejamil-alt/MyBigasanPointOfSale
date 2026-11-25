namespace MyBigasan
{
    partial class lblProductTitle
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtSearchProduct = new TextBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            lblSearchProduct = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblProductName = new Label();
            btnAddProduct = new Button();
            dataGridView1 = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colRiceVariety = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colSellingUnit = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnClearProductFields = new Button();
            btnRefreshProducts = new Button();
            cmbCategory = new ComboBox();
            lblSellingUnit = new Label();
            cmbSellingUnit = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 174, 58);
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT MANAGEMENT";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbSellingUnit);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(txtSearchProduct);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(lblSearchProduct);
            panel2.Controls.Add(lblStock);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblSellingUnit);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(lblProductName);
            panel2.Location = new Point(4, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 300);
            panel2.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(20, 263);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(358, 23);
            txtSearchProduct.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(197, 161);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(181, 23);
            txtStock.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(197, 115);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(181, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(197, 27);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(181, 23);
            txtProductName.TabIndex = 1;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchProduct.Location = new Point(20, 243);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(100, 17);
            lblSearchProduct.TabIndex = 0;
            lblSearchProduct.Text = "Search Product";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(20, 162);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(102, 17);
            lblStock.TabIndex = 0;
            lblStock.Text = "Available Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(20, 121);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(106, 17);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Selling Price (₱)";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(20, 73);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(93, 17);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Rice Category";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(20, 27);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(130, 17);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Rice Variety / Name";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(63, 169, 79);
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = SystemColors.ButtonHighlight;
            btnAddProduct.Location = new Point(88, 393);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(174, 32);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProductID, colRiceVariety, colCategory, colSellingUnit, colPrice, colStock });
            dataGridView1.Location = new Point(396, 89);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(644, 298);
            dataGridView1.TabIndex = 3;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "Product ID";
            colProductID.Name = "colProductID";
            colProductID.ReadOnly = true;
            // 
            // colRiceVariety
            // 
            colRiceVariety.HeaderText = "Rice Variety";
            colRiceVariety.Name = "colRiceVariety";
            colRiceVariety.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "colCategory";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colSellingUnit
            // 
            colSellingUnit.HeaderText = "Selling Unit";
            colSellingUnit.Name = "colSellingUnit";
            colSellingUnit.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price (₱)";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(63, 169, 79);
            btnUpdateProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProduct.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateProduct.Location = new Point(268, 393);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(174, 32);
            btnUpdateProduct.TabIndex = 2;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Maroon;
            btnDeleteProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProduct.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteProduct.Location = new Point(448, 393);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(174, 32);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnClearProductFields
            // 
            btnClearProductFields.BackColor = Color.FromArgb(206, 97, 38);
            btnClearProductFields.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearProductFields.ForeColor = SystemColors.ButtonHighlight;
            btnClearProductFields.Location = new Point(628, 393);
            btnClearProductFields.Name = "btnClearProductFields";
            btnClearProductFields.Size = new Size(174, 32);
            btnClearProductFields.TabIndex = 2;
            btnClearProductFields.Text = "Clear Fields";
            btnClearProductFields.UseVisualStyleBackColor = false;
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.BackColor = Color.FromArgb(0, 64, 0);
            btnRefreshProducts.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshProducts.ForeColor = SystemColors.ButtonHighlight;
            btnRefreshProducts.Location = new Point(808, 393);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(174, 32);
            btnRefreshProducts.TabIndex = 2;
            btnRefreshProducts.Text = "Refresh";
            btnRefreshProducts.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(197, 67);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(181, 23);
            cmbCategory.TabIndex = 2;
            // 
            // lblSellingUnit
            // 
            lblSellingUnit.AutoSize = true;
            lblSellingUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSellingUnit.Location = new Point(20, 204);
            lblSellingUnit.Name = "lblSellingUnit";
            lblSellingUnit.Size = new Size(80, 17);
            lblSellingUnit.TabIndex = 0;
            lblSellingUnit.Text = "Selling Unit";
            // 
            // cmbSellingUnit
            // 
            cmbSellingUnit.FormattingEnabled = true;
            cmbSellingUnit.Items.AddRange(new object[] { "5 kg", " 10 kg", "25 kg", " 50 kg" });
            cmbSellingUnit.Location = new Point(197, 204);
            cmbSellingUnit.Name = "cmbSellingUnit";
            cmbSellingUnit.Size = new Size(181, 23);
            cmbSellingUnit.TabIndex = 2;
            // 
            // lblProductTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 221);
            ClientSize = new Size(1039, 453);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefreshProducts);
            Controls.Add(btnClearProductFields);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "lblProductTitle";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtProductName;
        private Label lblCategory;
        private Label lblProductName;
        private Label lblPrice;
        private TextBox txtSearchProduct;
        private TextBox txtStock;
        private TextBox txtPrice;
        private Label lblSearchProduct;
        private Label lblStock;
        private Button btnAddProduct;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colRiceVariety;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colSellingUnit;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnClearProductFields;
        private Button btnRefreshProducts;
        private ComboBox cmbCategory;
        private ComboBox cmbSellingUnit;
        private Label lblSellingUnit;
    }
}