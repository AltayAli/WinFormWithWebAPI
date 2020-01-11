namespace PersonApiRealization
{
    partial class Form1
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
            this.InsertOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_insert_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insert_Surname = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.txt_insert_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.update_status = new System.Windows.Forms.Label();
            this.txt_update_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_update_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_update_Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_update_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_status = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.deleted_status = new System.Windows.Forms.Label();
            this.InsertOperationGroupBox.SuspendLayout();
            this.UpdateOperationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertOperationGroupBox
            // 
            this.InsertOperationGroupBox.Controls.Add(this.insert_status);
            this.InsertOperationGroupBox.Controls.Add(this.btnInsert);
            this.InsertOperationGroupBox.Controls.Add(this.txt_insert_Email);
            this.InsertOperationGroupBox.Controls.Add(this.label3);
            this.InsertOperationGroupBox.Controls.Add(this.txt_insert_Surname);
            this.InsertOperationGroupBox.Controls.Add(this.Surname);
            this.InsertOperationGroupBox.Controls.Add(this.txt_insert_Name);
            this.InsertOperationGroupBox.Controls.Add(this.label1);
            this.InsertOperationGroupBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertOperationGroupBox.Location = new System.Drawing.Point(24, 13);
            this.InsertOperationGroupBox.Name = "InsertOperationGroupBox";
            this.InsertOperationGroupBox.Size = new System.Drawing.Size(249, 307);
            this.InsertOperationGroupBox.TabIndex = 0;
            this.InsertOperationGroupBox.TabStop = false;
            this.InsertOperationGroupBox.Text = "Insert Operation";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(80, 254);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 36);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txt_insert_Email
            // 
            this.txt_insert_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert_Email.Location = new System.Drawing.Point(80, 121);
            this.txt_insert_Email.Name = "txt_insert_Email";
            this.txt_insert_Email.Size = new System.Drawing.Size(149, 25);
            this.txt_insert_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txt_insert_Surname
            // 
            this.txt_insert_Surname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert_Surname.Location = new System.Drawing.Point(80, 79);
            this.txt_insert_Surname.Name = "txt_insert_Surname";
            this.txt_insert_Surname.Size = new System.Drawing.Size(149, 25);
            this.txt_insert_Surname.TabIndex = 3;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(19, 82);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(64, 18);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // txt_insert_Name
            // 
            this.txt_insert_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert_Name.Location = new System.Drawing.Point(80, 37);
            this.txt_insert_Name.Name = "txt_insert_Name";
            this.txt_insert_Name.Size = new System.Drawing.Size(149, 25);
            this.txt_insert_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // UpdateOperationGroupBox
            // 
            this.UpdateOperationGroupBox.Controls.Add(this.update_status);
            this.UpdateOperationGroupBox.Controls.Add(this.txt_update_id);
            this.UpdateOperationGroupBox.Controls.Add(this.label6);
            this.UpdateOperationGroupBox.Controls.Add(this.btn_update);
            this.UpdateOperationGroupBox.Controls.Add(this.txt_update_Email);
            this.UpdateOperationGroupBox.Controls.Add(this.label2);
            this.UpdateOperationGroupBox.Controls.Add(this.txt_update_Surname);
            this.UpdateOperationGroupBox.Controls.Add(this.label4);
            this.UpdateOperationGroupBox.Controls.Add(this.txt_update_Name);
            this.UpdateOperationGroupBox.Controls.Add(this.label5);
            this.UpdateOperationGroupBox.Enabled = false;
            this.UpdateOperationGroupBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOperationGroupBox.Location = new System.Drawing.Point(304, 13);
            this.UpdateOperationGroupBox.Name = "UpdateOperationGroupBox";
            this.UpdateOperationGroupBox.Size = new System.Drawing.Size(249, 307);
            this.UpdateOperationGroupBox.TabIndex = 7;
            this.UpdateOperationGroupBox.TabStop = false;
            this.UpdateOperationGroupBox.Text = "Update Operation";
            // 
            // update_status
            // 
            this.update_status.AutoSize = true;
            this.update_status.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_status.Location = new System.Drawing.Point(17, 218);
            this.update_status.Name = "update_status";
            this.update_status.Size = new System.Drawing.Size(0, 18);
            this.update_status.TabIndex = 9;
            // 
            // txt_update_id
            // 
            this.txt_update_id.Enabled = false;
            this.txt_update_id.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_id.Location = new System.Drawing.Point(78, 40);
            this.txt_update_id.Name = "txt_update_id";
            this.txt_update_id.Size = new System.Drawing.Size(149, 25);
            this.txt_update_id.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(78, 254);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(92, 36);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_Email
            // 
            this.txt_update_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_Email.Location = new System.Drawing.Point(78, 166);
            this.txt_update_Email.Name = "txt_update_Email";
            this.txt_update_Email.Size = new System.Drawing.Size(149, 25);
            this.txt_update_Email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // txt_update_Surname
            // 
            this.txt_update_Surname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_Surname.Location = new System.Drawing.Point(78, 124);
            this.txt_update_Surname.Name = "txt_update_Surname";
            this.txt_update_Surname.Size = new System.Drawing.Size(149, 25);
            this.txt_update_Surname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname";
            // 
            // txt_update_Name
            // 
            this.txt_update_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_Name.Location = new System.Drawing.Point(78, 82);
            this.txt_update_Name.Name = "txt_update_Name";
            this.txt_update_Name.Size = new System.Drawing.Size(149, 25);
            this.txt_update_Name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // insert_status
            // 
            this.insert_status.AutoSize = true;
            this.insert_status.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_status.Location = new System.Drawing.Point(19, 173);
            this.insert_status.Name = "insert_status";
            this.insert_status.Size = new System.Drawing.Size(0, 18);
            this.insert_status.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 322);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(499, 377);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 36);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // deleted_status
            // 
            this.deleted_status.AutoSize = true;
            this.deleted_status.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleted_status.Location = new System.Drawing.Point(376, 336);
            this.deleted_status.Name = "deleted_status";
            this.deleted_status.Size = new System.Drawing.Size(0, 18);
            this.deleted_status.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 425);
            this.Controls.Add(this.deleted_status);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateOperationGroupBox);
            this.Controls.Add(this.InsertOperationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.InsertOperationGroupBox.ResumeLayout(false);
            this.InsertOperationGroupBox.PerformLayout();
            this.UpdateOperationGroupBox.ResumeLayout(false);
            this.UpdateOperationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertOperationGroupBox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txt_insert_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_insert_Surname;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txt_insert_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UpdateOperationGroupBox;
        private System.Windows.Forms.TextBox txt_update_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_update_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_update_Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_update_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label update_status;
        private System.Windows.Forms.Label insert_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label deleted_status;
    }
}

