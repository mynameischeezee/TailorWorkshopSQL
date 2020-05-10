namespace TailorWorkshopSQL
{
    partial class DeleteOperationForm
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Delete.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(246, 204);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 45);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Видалити";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(12, 204);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(126, 45);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtBox_ID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_ID.Location = new System.Drawing.Point(66, 53);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(306, 26);
            this.txtBox_ID.TabIndex = 6;
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.AutoSize = true;
            this.lbl_TableName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TableName.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_TableName.Location = new System.Drawing.Point(26, 53);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(34, 25);
            this.lbl_TableName.TabIndex = 7;
            this.lbl_TableName.Text = "ID:";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Info.Location = new System.Drawing.Point(26, 25);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(88, 25);
            this.lbl_Info.TabIndex = 8;
            this.lbl_Info.Text = "Info_text:";
            // 
            // DeleteOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_TableName);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOperationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Label lbl_TableName;
        public System.Windows.Forms.Label lbl_Info;
    }
}