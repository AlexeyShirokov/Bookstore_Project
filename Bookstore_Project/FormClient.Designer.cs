namespace Bookstore_Project
{
    partial class FormClient
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(211, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(313, 385);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(405, 385);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(9, 63);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 117);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(9, 173);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 225);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Почта";
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(164, 31);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(410, 327);
            this.listViewClient.TabIndex = 8;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Почта";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 31);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 79);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 241);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 133);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 189);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 13;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}