using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    public partial class FormProductTraking : Form
    {
        public FormProductTraking()
        {
            InitializeComponent();
            ShowClient();
            ShowProduct();
            ShowWorker();
        }

        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet clientSet in Program.mpgc.ClientSet)
            {
                string[] item = {clientSet.Id.ToString()+". "+clientSet.FirstName, clientSet.MiddleName, clientSet.LastName};
                comboBoxClient.Items.Add(string.Join(" ", item));

            }
        }
        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.mpgc.ProductSet)
            {
                string[] item = {productSet.Id.ToString()+". "+productSet.Author, productSet.Name,productSet.GameName, productSet.NameOfficeSupply};
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach(WorkerSet workerSet in Program.mpgc.WorkerSet)
            {
                string[] item = { workerSet.Id.ToString() + ". " + workerSet.FirstName, workerSet.MiddleName, workerSet.LastName };
                comboBoxWorker.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
