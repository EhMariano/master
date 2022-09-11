namespace StaowiskoApp
{
    partial class Settings
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
            this.dataGridViewSmuSettings = new System.Windows.Forms.DataGridView();
            this.btnLoadSettingsFromXml = new System.Windows.Forms.Button();
            this.DevicesDataSet = new System.Data.DataSet();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Params = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmuSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSmuSettings
            // 
            this.dataGridViewSmuSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSmuSettings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSmuSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmuSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device,
            this.Params,
            this.Value});
            this.dataGridViewSmuSettings.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSmuSettings.Name = "dataGridViewSmuSettings";
            this.dataGridViewSmuSettings.ReadOnly = true;
            this.dataGridViewSmuSettings.RowHeadersWidth = 51;
            this.dataGridViewSmuSettings.RowTemplate.Height = 24;
            this.dataGridViewSmuSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSmuSettings.Size = new System.Drawing.Size(620, 417);
            this.dataGridViewSmuSettings.TabIndex = 1;
            // 
            // btnLoadSettingsFromXml
            // 
            this.btnLoadSettingsFromXml.Location = new System.Drawing.Point(525, 435);
            this.btnLoadSettingsFromXml.Name = "btnLoadSettingsFromXml";
            this.btnLoadSettingsFromXml.Size = new System.Drawing.Size(107, 33);
            this.btnLoadSettingsFromXml.TabIndex = 3;
            this.btnLoadSettingsFromXml.Text = "LOAD";
            this.btnLoadSettingsFromXml.UseVisualStyleBackColor = true;
            this.btnLoadSettingsFromXml.Click += new System.EventHandler(this.ReadXmlButton_Click);
            // 
            // DevicesDataSet
            // 
            this.DevicesDataSet.DataSetName = "NewDataSet";
            // 
            // Device
            // 
            this.Device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Device.HeaderText = "Device Type";
            this.Device.MinimumWidth = 6;
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            this.Device.Width = 114;
            // 
            // Params
            // 
            this.Params.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Params.HeaderText = "Param Name";
            this.Params.MinimumWidth = 6;
            this.Params.Name = "Params";
            this.Params.ReadOnly = true;
            this.Params.Width = 116;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 71;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 475);
            this.Controls.Add(this.btnLoadSettingsFromXml);
            this.Controls.Add(this.dataGridViewSmuSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmuSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSmuSettings;
        private System.Windows.Forms.Button btnLoadSettingsFromXml;
        private System.Data.DataSet DevicesDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Params;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}