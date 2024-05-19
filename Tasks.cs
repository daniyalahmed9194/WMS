using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMSLibrary;
using WMSLibrary.DL;
using WMSLibrary.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;
using System.Xml.Linq;

namespace WMSForms
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            LoadVolunteerCombo();
            LoadBeneficiaryCombo();
            LoadInventoryCombo();
            Load_Invertory();
        }

        //int identity = 0;

        private void LoadVolunteerCombo()
        {
            List<int> VolunteerIDs = VolunteerDL.GetVolunteerIDs();
            foreach (int id in VolunteerIDs)
            {
                VolunteerCombo.Items.Add(id);
            }
        }
        
        private void LoadInventoryCombo()
        {
            List<int> InventoryIDs = InventoryDL.GetInventoryIDs();
            foreach (int id in InventoryIDs)
            {
                InvenCombo.Items.Add(id);
            }
        }

        private static DataTable dataTable = new DataTable();
        private void Load_Invertory()
        {
            dataTable.Clear();
            AddColumnIfNotExists("Inventory ID", typeof(int));
            AddColumnIfNotExists("Item Name", typeof(string));
            AddColumnIfNotExists("Quantity", typeof(int));

             dataGridView1.DataSource = dataTable;

            List<Inventories> InventoryList = ObjectHandler.GetInventoryDL().GetAllInventory();
            foreach (Inventories inven in InventoryList)
            {
                dataTable.Rows.Add(inven.GetID(), inven.GetName(), inven.GetQuantity());
            }
        }

        private void AddColumnIfNotExists(string columnName, Type columnType)
        {
            if (!dataTable.Columns.Contains(columnName))
            {
                dataTable.Columns.Add(columnName, columnType);
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }

        private void LoadBeneficiaryCombo()
        {
            List<int> BeneficiaryIds = BeneficiaryDL.GetBeneficiaryIDs();
            foreach (int id in BeneficiaryIds)
            {
                BeneficiaryCombo.Items.Add(id);
            }
        }

        private void VolunteerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VolName.Text = VolunteerDL.FindVolName(int.Parse(VolunteerCombo.Text));
        }

        /* private void BeneficiaryCombo_SelectedIndexChanged(object sender, EventArgs e)
         {
             int id = int.Parse(BeneficiaryCombo.Text);
             BeneficiaryName.Text = BeneficiaryDL.FindBeneName(id);
             BeneficiaryNeed.Text = BeneficiaryDL.FindBeneNeed(id);
         }*/

        private void BeneficiaryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(BeneficiaryCombo.Text, out int beneficiaryId))
            {
                BeneficiaryName.Text = BeneficiaryDL.FindBeneName(beneficiaryId);
                BeneficiaryNeed.Text = BeneficiaryDL.FindBeneNeed(beneficiaryId);
                label1.Text = BeneficiaryDL.FindBeneNeedQty(beneficiaryId).ToString();
            }
            else
            {
                MessageBox.Show("Nahi hoa");
                
            }
        }


        private void VolName_Click(object sender, EventArgs e)
        {
           
        }

        private void BeneficiaryName_Click(object sender, EventArgs e)
        {

        }

        private void BeneficiaryNeed_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvenCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(InvenCombo.Text);
            Item.Text = InventoryDL.FindItemName(id);
            qty.Text =  InventoryDL.FindInvenQty(id).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {

                InvenCombo.Text = row.Cells[1].Value.ToString();
                Item.Text = row.Cells[2].Value.ToString();
                qty.Text = row.Cells[3].Value.ToString();

            }
            //identity = string.IsNullOrEmpty(row.Cells[0].Value?.ToString()) ? 0 : Convert.ToInt32(row.Cells[0].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Need = BeneficiaryNeed.Text;
            int quan = int.Parse(label1.Text);
            Inventories invo = new Inventories(Need, quan);
            int value = InventoryDL.Check(BeneficiaryNeed.Text);
            value -= int.Parse(label1.Text);
            if(value >= 0)
            {
                if (ObjectHandler.GetInventoryDL().UpdateInventoryDel(invo))
                {
                    MessageBox.Show("Successful");
                }
            }
            else
            {
                MessageBox.Show("Not Enough Quantity");
            }
            
        }
    }
}