namespace KR
{
    partial class TenantsForm
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridViewTenants = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonBack = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(578, 296);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(119, 44);
			this.buttonDelete.TabIndex = 22;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChange.Location = new System.Drawing.Point(294, 296);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(119, 44);
			this.buttonChange.TabIndex = 21;
			this.buttonChange.Text = "Изменить";
			this.buttonChange.UseVisualStyleBackColor = false;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(13, 296);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(119, 44);
			this.buttonAdd.TabIndex = 20;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = false;
			// 
			// dataGridViewTenants
			// 
			this.dataGridViewTenants.AutoGenerateColumns = false;
			this.dataGridViewTenants.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Phone,
            this.Adress});
			this.dataGridViewTenants.DataSource = this.tenantsBindingSource;
			this.dataGridViewTenants.Location = new System.Drawing.Point(8, 55);
			this.dataGridViewTenants.Name = "dataGridViewTenants";
			this.dataGridViewTenants.Size = new System.Drawing.Size(693, 215);
			this.dataGridViewTenants.TabIndex = 19;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "Phone";
			this.Phone.Name = "Phone";
			// 
			// Adress
			// 
			this.Adress.DataPropertyName = "Adress";
			this.Adress.HeaderText = "Adress";
			this.Adress.Name = "Adress";
			// 
			// tenantsBindingSource
			// 
			this.tenantsBindingSource.DataSource = typeof(KR.DataModel.Tenants);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Location = new System.Drawing.Point(8, 11);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 18;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(-1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(710, 43);
			this.label3.TabIndex = 17;
			this.label3.Text = "Арендаторы";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mallBindingSource
			// 
			this.mallBindingSource.DataSource = typeof(KR.DataModel.Mall);
			// 
			// TenantsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(708, 351);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewTenants);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "TenantsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.TenantsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewTenants;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource tenantsBindingSource;
		private System.Windows.Forms.BindingSource mallBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
	}
}