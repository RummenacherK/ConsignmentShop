namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.components = new System.ComponentModel.Container();
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxlabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purplecobrasDataSet = new ConsignmentShopUI.purplecobrasDataSet();
            this.budgetTableAdapter = new ConsignmentShopUI.purplecobrasDataSetTableAdapters.BudgetTableAdapter();
            this.tableAdapterManager = new ConsignmentShopUI.purplecobrasDataSetTableAdapters.TableAdapterManager();
            this.purplecobrasDataSet1 = new ConsignmentShopUI.purplecobrasDataSet1();
            this.trumpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trumpTableAdapter = new ConsignmentShopUI.purplecobrasDataSet1TableAdapters.TrumpTableAdapter();
            this.tableAdapterManager1 = new ConsignmentShopUI.purplecobrasDataSet1TableAdapters.TableAdapterManager();
            this.trumpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecobrasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecobrasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerText.Location = new System.Drawing.Point(30, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(358, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Trump Change";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 29;
            this.itemsListbox.Location = new System.Drawing.Point(40, 113);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(372, 207);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemsListboxlabel
            // 
            this.itemsListboxlabel.AutoSize = true;
            this.itemsListboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemsListboxlabel.Location = new System.Drawing.Point(35, 80);
            this.itemsListboxlabel.Name = "itemsListboxlabel";
            this.itemsListboxlabel.Size = new System.Drawing.Size(146, 29);
            this.itemsListboxlabel.TabIndex = 2;
            this.itemsListboxlabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToCart.Location = new System.Drawing.Point(427, 202);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(183, 46);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart →";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(623, 80);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(180, 29);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            this.shoppingCartListboxLabel.Click += new System.EventHandler(this.shoppingCartListboxLabel_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 29;
            this.shoppingCartListbox.Location = new System.Drawing.Point(628, 112);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(372, 207);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.makePurchase.Location = new System.Drawing.Point(871, 325);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(129, 46);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vendorListboxLabel.Location = new System.Drawing.Point(35, 394);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(110, 29);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 29;
            this.vendorListBox.Location = new System.Drawing.Point(40, 426);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(372, 207);
            this.vendorListBox.TabIndex = 7;
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storePayoutLabel.Location = new System.Drawing.Point(600, 426);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(203, 29);
            this.storePayoutLabel.TabIndex = 9;
            this.storePayoutLabel.Text = "The Yuge Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeProfitValue.Location = new System.Drawing.Point(809, 426);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(76, 29);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            this.storeProfitValue.Click += new System.EventHandler(this.storeProfitValue_Click);
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.purplecobrasDataSet;
            // 
            // purplecobrasDataSet
            // 
            this.purplecobrasDataSet.DataSetName = "purplecobrasDataSet";
            this.purplecobrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = this.budgetTableAdapter;
            this.tableAdapterManager.InventoryImageTableAdapter = null;
            this.tableAdapterManager.InventoryTestTableBenTableAdapter = null;
            this.tableAdapterManager.InventoryTestTableTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.TestTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ConsignmentShopUI.purplecobrasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purplecobrasDataSet1
            // 
            this.purplecobrasDataSet1.DataSetName = "purplecobrasDataSet1";
            this.purplecobrasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trumpBindingSource
            // 
            this.trumpBindingSource.DataMember = "Trump";
            this.trumpBindingSource.DataSource = this.purplecobrasDataSet1;
            // 
            // trumpTableAdapter
            // 
            this.trumpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TrumpTableAdapter = this.trumpTableAdapter;
            this.tableAdapterManager1.UpdateOrder = ConsignmentShopUI.purplecobrasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trumpDataGridView
            // 
            this.trumpDataGridView.AutoGenerateColumns = false;
            this.trumpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trumpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.trumpDataGridView.DataSource = this.trumpBindingSource;
            this.trumpDataGridView.Location = new System.Drawing.Point(459, 487);
            this.trumpDataGridView.Name = "trumpDataGridView";
            this.trumpDataGridView.RowTemplate.Height = 28;
            this.trumpDataGridView.Size = new System.Drawing.Size(541, 95);
            this.trumpDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Yuge";
            this.dataGridViewTextBoxColumn5.HeaderText = "Yuge";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1035, 654);
            this.Controls.Add(this.trumpDataGridView);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxlabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsignmentShop";
            this.Text = "Trump Change";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecobrasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecobrasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxlabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private purplecobrasDataSet purplecobrasDataSet;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private purplecobrasDataSetTableAdapters.BudgetTableAdapter budgetTableAdapter;
        private purplecobrasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private purplecobrasDataSet1 purplecobrasDataSet1;
        private System.Windows.Forms.BindingSource trumpBindingSource;
        private purplecobrasDataSet1TableAdapters.TrumpTableAdapter trumpTableAdapter;
        private purplecobrasDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView trumpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

