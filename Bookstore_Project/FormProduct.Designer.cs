namespace Bookstore_Project
{
    partial class FormProduct
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewOfficeSupplies = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTableGames = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNameOfficeSupply = new System.Windows.Forms.TextBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameOfficeSupply = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Книги",
            "Настольные игры",
            "Канцтовары"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 57);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listViewOfficeSupplies
            // 
            this.listViewOfficeSupplies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewOfficeSupplies.FullRowSelect = true;
            this.listViewOfficeSupplies.GridLines = true;
            this.listViewOfficeSupplies.HideSelection = false;
            this.listViewOfficeSupplies.Location = new System.Drawing.Point(854, 12);
            this.listViewOfficeSupplies.MultiSelect = false;
            this.listViewOfficeSupplies.Name = "listViewOfficeSupplies";
            this.listViewOfficeSupplies.Size = new System.Drawing.Size(299, 304);
            this.listViewOfficeSupplies.TabIndex = 1;
            this.listViewOfficeSupplies.UseCompatibleStateImageBehavior = false;
            this.listViewOfficeSupplies.View = System.Windows.Forms.View.Details;
            this.listViewOfficeSupplies.SelectedIndexChanged += new System.EventHandler(this.listViewOfficeSupplies_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Наименование товара ";
            this.columnHeader4.Width = 366;
            // 
            // listViewBooks
            // 
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(201, 9);
            this.listViewBooks.MultiSelect = false;
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(631, 178);
            this.listViewBooks.TabIndex = 2;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.Visible = false;
            this.listViewBooks.SelectedIndexChanged += new System.EventHandler(this.listViewBooks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Автор ";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название ";
            this.columnHeader2.Width = 181;
            // 
            // listViewTableGames
            // 
            this.listViewTableGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewTableGames.FullRowSelect = true;
            this.listViewTableGames.GridLines = true;
            this.listViewTableGames.HideSelection = false;
            this.listViewTableGames.Location = new System.Drawing.Point(201, 193);
            this.listViewTableGames.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.listViewTableGames.MultiSelect = false;
            this.listViewTableGames.Name = "listViewTableGames";
            this.listViewTableGames.Size = new System.Drawing.Size(631, 123);
            this.listViewTableGames.TabIndex = 3;
            this.listViewTableGames.UseCompatibleStateImageBehavior = false;
            this.listViewTableGames.View = System.Windows.Forms.View.Details;
            this.listViewTableGames.SelectedIndexChanged += new System.EventHandler(this.listViewTableGames_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название игры";
            this.columnHeader3.Width = 364;
            // 
            // textBoxNameOfficeSupply
            // 
            this.textBoxNameOfficeSupply.Location = new System.Drawing.Point(12, 167);
            this.textBoxNameOfficeSupply.Name = "textBoxNameOfficeSupply";
            this.textBoxNameOfficeSupply.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameOfficeSupply.TabIndex = 4;
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(12, 117);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameName.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(12, 223);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 273);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(81, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 41);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(67, 13);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип товара ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 207);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(37, 13);
            this.labelAuthor.TabIndex = 9;
            this.labelAuthor.Text = "Автор";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(9, 98);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(85, 13);
            this.labelGameName.TabIndex = 10;
            this.labelGameName.Text = "Название игры";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 257);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Название ";
            // 
            // labelNameOfficeSupply
            // 
            this.labelNameOfficeSupply.AutoSize = true;
            this.labelNameOfficeSupply.Location = new System.Drawing.Point(9, 148);
            this.labelNameOfficeSupply.Name = "labelNameOfficeSupply";
            this.labelNameOfficeSupply.Size = new System.Drawing.Size(148, 13);
            this.labelNameOfficeSupply.TabIndex = 12;
            this.labelNameOfficeSupply.Text = "Наименование канцтовара ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(42, 345);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 37);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(140, 345);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 37);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(238, 345);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(92, 37);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 395);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNameOfficeSupply);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.textBoxNameOfficeSupply);
            this.Controls.Add(this.listViewTableGames);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.listViewOfficeSupplies);
            this.Controls.Add(this.comboBoxType);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewOfficeSupplies;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ListView listViewTableGames;
        private System.Windows.Forms.TextBox textBoxNameOfficeSupply;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameOfficeSupply;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}