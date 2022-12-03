using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.ninject;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private IProductService _productservice = InstanceFactory.GetInstance<IProductService>();
        private ICategoryService _categoryservice = InstanceFactory.GetInstance<ICategoryService>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            cbxKategoriSırala.DataSource = _categoryservice.GetCategories();
            cbxKategoriSırala.DisplayMember = "CategoryName";
            cbxKategoriSırala.ValueMember = "CategoryID";
            cbxKategori.DataSource = _categoryservice.GetCategories();
            cbxKategori.DisplayMember = "CategoryName";
            cbxKategori.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _productservice.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxUrunAra.Text))
            {
                dataGridView1.DataSource = _productservice.GetProductsByProductName(tbxUrunAra.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _productservice.GetByCategory(Convert.ToInt32(cbxKategoriSırala.SelectedValue));

            }
            catch
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _productservice.Add(new Product
                {
                    ProductName = tbxUrun.Text,
                    CategoryID = Convert.ToInt32(cbxKategori.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxFiyat.Text),
                    UnitsInStock = Convert.ToInt16(tbxStok.Text),
                    QuantityPerUnit = tbxBirim.Text

                });
                LoadProducts();
            }
            catch 
            {

                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _productservice.Delete(new Product
                {
                    ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
                LoadProducts();
            }
            catch
            {

               
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrun.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxFiyat.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxStok.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxBirim.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _productservice.Update(new Product
            {
                ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ProductName = tbxUrun.Text,
                CategoryID = Convert.ToInt32(cbxKategori.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxFiyat.Text),
                UnitsInStock = Convert.ToInt16(tbxStok.Text),
                QuantityPerUnit = tbxBirim.Text

            });
            LoadProducts();
        }
    }
}
