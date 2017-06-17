using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_EF_Code_First_Sample
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AmazingShop context = new AmazingShop();   
                Category Sci_Fi = new Category();
                Sci_Fi.CategoryName = txtBookCategory.Text;
                Sci_Fi.Products = new List<Product>
                {
                    new Product
                    {
                        ProductName = txtBookName.Text,
                        ListPrice = Convert.ToDecimal(txtBookPrice.Text),
                        CategoryID =Sci_Fi.CategoryID
                    }
                };
                context.Categories.Add(Sci_Fi);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Process is successful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("There is a problem while saving changes ");
                }
            
        }
    }
}
