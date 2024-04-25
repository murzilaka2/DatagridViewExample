namespace WinFormsApp3
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
            panel1 = new Panel();
            DataSourceButton = new Panel();
            PrintButton = new Button();
            AddColumnButton = new Button();
            RefreshButton = new Button();
            SetDataSourceButton = new Button();
            RemoveRowButton = new Button();
            AddRowButton = new Button();
            UpdateColumnsButton = new Button();
            RemoveCellButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            DataSourceButton.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 350);
            panel1.TabIndex = 0;
            // 
            // DataSourceButton
            // 
            DataSourceButton.Controls.Add(PrintButton);
            DataSourceButton.Controls.Add(AddColumnButton);
            DataSourceButton.Controls.Add(RefreshButton);
            DataSourceButton.Controls.Add(SetDataSourceButton);
            DataSourceButton.Controls.Add(RemoveRowButton);
            DataSourceButton.Controls.Add(AddRowButton);
            DataSourceButton.Controls.Add(UpdateColumnsButton);
            DataSourceButton.Controls.Add(RemoveCellButton);
            DataSourceButton.Dock = DockStyle.Bottom;
            DataSourceButton.Location = new Point(0, 350);
            DataSourceButton.Name = "DataSourceButton";
            DataSourceButton.Size = new Size(800, 100);
            DataSourceButton.TabIndex = 1;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(244, 35);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(94, 23);
            PrintButton.TabIndex = 6;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // AddColumnButton
            // 
            AddColumnButton.Location = new Point(244, 6);
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.Size = new Size(94, 23);
            AddColumnButton.TabIndex = 0;
            AddColumnButton.Text = "Add Column";
            AddColumnButton.UseVisualStyleBackColor = true;
            AddColumnButton.Click += AddColumnButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(131, 35);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(107, 23);
            RefreshButton.TabIndex = 5;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SetDataSourceButton
            // 
            SetDataSourceButton.Location = new Point(12, 35);
            SetDataSourceButton.Name = "SetDataSourceButton";
            SetDataSourceButton.Size = new Size(113, 23);
            SetDataSourceButton.TabIndex = 4;
            SetDataSourceButton.Text = "Data Source";
            SetDataSourceButton.UseVisualStyleBackColor = true;
            SetDataSourceButton.Click += SetDataSourceButton_Click;
            // 
            // RemoveRowButton
            // 
            RemoveRowButton.Location = new Point(449, 6);
            RemoveRowButton.Name = "RemoveRowButton";
            RemoveRowButton.Size = new Size(99, 23);
            RemoveRowButton.TabIndex = 3;
            RemoveRowButton.Text = "Remove Row";
            RemoveRowButton.UseVisualStyleBackColor = true;
            RemoveRowButton.Click += RemoveRowButton_Click;
            // 
            // AddRowButton
            // 
            AddRowButton.Location = new Point(344, 6);
            AddRowButton.Name = "AddRowButton";
            AddRowButton.Size = new Size(99, 23);
            AddRowButton.TabIndex = 2;
            AddRowButton.Text = "Add Row";
            AddRowButton.UseVisualStyleBackColor = true;
            AddRowButton.Click += AddRowButton_Click;
            // 
            // UpdateColumnsButton
            // 
            UpdateColumnsButton.Location = new Point(131, 6);
            UpdateColumnsButton.Name = "UpdateColumnsButton";
            UpdateColumnsButton.Size = new Size(107, 23);
            UpdateColumnsButton.TabIndex = 1;
            UpdateColumnsButton.Text = "Update Column";
            UpdateColumnsButton.UseVisualStyleBackColor = true;
            UpdateColumnsButton.Click += UpdateColumnsButton_Click;
            // 
            // RemoveCellButton
            // 
            RemoveCellButton.Location = new Point(12, 6);
            RemoveCellButton.Name = "RemoveCellButton";
            RemoveCellButton.Size = new Size(113, 23);
            RemoveCellButton.TabIndex = 0;
            RemoveCellButton.Text = "Remove Cell";
            RemoveCellButton.UseVisualStyleBackColor = true;
            RemoveCellButton.Click += RemoveCellButton_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataSourceButton);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            DataSourceButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel DataSourceButton;
        private Button RemoveCellButton;
        private Button UpdateColumnsButton;
        private Button AddRowButton;
        private Button RemoveRowButton;
        private Button SetDataSourceButton;
        private Button RefreshButton;
        private Button AddColumnButton;
        private Button PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
