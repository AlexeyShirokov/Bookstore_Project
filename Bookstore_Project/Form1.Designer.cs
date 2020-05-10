namespace Bookstore_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenWorker = new System.Windows.Forms.Button();
            this.buttonOpenProduct = new System.Windows.Forms.Button();
            this.buttonOpenProductTraking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(24, 40);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenClients.TabIndex = 0;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenWorker
            // 
            this.buttonOpenWorker.Location = new System.Drawing.Point(24, 120);
            this.buttonOpenWorker.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenWorker.Name = "buttonOpenWorker";
            this.buttonOpenWorker.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenWorker.TabIndex = 1;
            this.buttonOpenWorker.Text = "Сотрудники";
            this.buttonOpenWorker.UseVisualStyleBackColor = true;
            this.buttonOpenWorker.Click += new System.EventHandler(this.buttonOpenWorker_Click);
            // 
            // buttonOpenProduct
            // 
            this.buttonOpenProduct.Location = new System.Drawing.Point(24, 200);
            this.buttonOpenProduct.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenProduct.Name = "buttonOpenProduct";
            this.buttonOpenProduct.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenProduct.TabIndex = 2;
            this.buttonOpenProduct.Text = "Товары";
            this.buttonOpenProduct.UseVisualStyleBackColor = true;
            this.buttonOpenProduct.Click += new System.EventHandler(this.buttonOpenProduct_Click);
            // 
            // buttonOpenProductTraking
            // 
            this.buttonOpenProductTraking.Location = new System.Drawing.Point(24, 280);
            this.buttonOpenProductTraking.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenProductTraking.Name = "buttonOpenProductTraking";
            this.buttonOpenProductTraking.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenProductTraking.TabIndex = 3;
            this.buttonOpenProductTraking.Text = "Покупка";
            this.buttonOpenProductTraking.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 357);
            this.Controls.Add(this.buttonOpenProductTraking);
            this.Controls.Add(this.buttonOpenProduct);
            this.Controls.Add(this.buttonOpenWorker);
            this.Controls.Add(this.buttonOpenClients);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenWorker;
        private System.Windows.Forms.Button buttonOpenProduct;
        private System.Windows.Forms.Button buttonOpenProductTraking;
    }
}

