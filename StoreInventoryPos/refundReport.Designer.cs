namespace StoreInventoryPos
{
    partial class refundReport
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
        /// 


        private void InitializeComponent()
        {
            searchGrid = new DataGridView();
            backButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            searchField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(35, 68);
            searchGrid.Margin = new Padding(3, 2, 3, 2);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(1050, 300);
            searchGrid.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(980, 22);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 38);
            backButton.TabIndex = 17;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(541, 22);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(131, 33);
            clearButton.TabIndex = 18;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 19;
            label1.Text = "Search :";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(142, 22);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(384, 31);
            searchField.TabIndex = 37;
            // 
            // refundReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 435);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "refundReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refund Report";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridView searchGrid;
        #endregion

        private Button backButton;
        private Button clearButton;
        private Label label1;
        private TextBox searchField;
    }
}