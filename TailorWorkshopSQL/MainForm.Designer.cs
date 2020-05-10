namespace TailorWorkshopSQL
{
    partial class MainForm
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
            this.cmbBox_Tables = new System.Windows.Forms.ComboBox();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.lstBox_Data = new System.Windows.Forms.ListBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox_Tables
            // 
            this.cmbBox_Tables.BackColor = System.Drawing.Color.White;
            this.cmbBox_Tables.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmbBox_Tables.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBox_Tables.FormattingEnabled = true;
            this.cmbBox_Tables.Location = new System.Drawing.Point(156, 12);
            this.cmbBox_Tables.Name = "cmbBox_Tables";
            this.cmbBox_Tables.Size = new System.Drawing.Size(139, 33);
            this.cmbBox_Tables.TabIndex = 0;
            this.cmbBox_Tables.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Tables_SelectedIndexChanged);
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.AutoSize = true;
            this.lbl_TableName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TableName.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_TableName.Location = new System.Drawing.Point(12, 12);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(138, 25);
            this.lbl_TableName.TabIndex = 1;
            this.lbl_TableName.Text = "Назва таблиці:";
            // 
            // lstBox_Data
            // 
            this.lstBox_Data.BackColor = System.Drawing.Color.White;
            this.lstBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBox_Data.ForeColor = System.Drawing.Color.DimGray;
            this.lstBox_Data.FormattingEnabled = true;
            this.lstBox_Data.ItemHeight = 17;
            this.lstBox_Data.Location = new System.Drawing.Point(5, 56);
            this.lstBox_Data.Name = "lstBox_Data";
            this.lstBox_Data.Size = new System.Drawing.Size(1343, 663);
            this.lstBox_Data.TabIndex = 2;
            // 
            // btn_Find
            // 
            this.btn_Find.FlatAppearance.BorderSize = 0;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Find.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(301, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(152, 45);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "Знайти за ID:";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtBox_ID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_ID.Location = new System.Drawing.Point(459, 15);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(96, 26);
            this.txtBox_ID.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Add.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Add.Image = global::TailorWorkshopSQL.Properties.Resources.Upate35px_light;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(561, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 45);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Додати";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Update.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Update.Image = global::TailorWorkshopSQL.Properties.Resources.Upate2_35px_light;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(693, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(126, 45);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Змінити";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Delete.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Delete.Image = global::TailorWorkshopSQL.Properties.Resources.Delete2_35px_light;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Delete.Location = new System.Drawing.Point(825, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(136, 45);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Видалити";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lstBox_Data);
            this.Controls.Add(this.lbl_TableName);
            this.Controls.Add(this.cmbBox_Tables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Tailor Workshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_Tables;
        private System.Windows.Forms.Label lbl_TableName;
        private System.Windows.Forms.ListBox lstBox_Data;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txtBox_ID;
    }
}

