using DBFirst_WinForm_Customers.Models;

namespace DBFirst_WinForm_Customers
{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();

            Listele();
        }

        private void Listele()
        {
            dgvMusteriler.DataSource = null;
            dgvMusteriler.DataSource = _db.Customers.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((_db.Customers.Find(txtId.Text) != null))
            {
                MessageBox.Show("Bu Id ye ait musteri zaten var, baska musteri ekleyin");
                return;
            }
            DBFirst_WinForm_Customers.Models.Customer yeniMusteri = new DBFirst_WinForm_Customers.Models.Customer();

            yeniMusteri.CustomerId = txtId.Text;
            yeniMusteri.CompanyName = txtSýrketAdý.Text;

            _db.Customers.Add(yeniMusteri);

            _db.SaveChanges();

            Listele();

            MessageBox.Show(txtSýrketAdý.Text + " musterilere eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DBFirst_WinForm_Customers.Models.Customer guncellenecekMusteri = _db.Customers.FirstOrDefault(r => r.CustomerId == txtId.Text)!;

                guncellenecekMusteri.CompanyName = txtSýrketAdý.Text;

                _db.SaveChanges();

                Listele();

                MessageBox.Show("Guncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSýl_Click(object sender, EventArgs e)
        {
            string tanim;
            DBFirst_WinForm_Customers.Models.Customer silinecekMusteri = _db.Customers.FirstOrDefault(r => r.CustomerId == txtId.Text)!;

            if (silinecekMusteri == null)
            {
                MessageBox.Show("Bu Id ye ait musteri bulunmamaktadýr!");
                return;
            }
            tanim = silinecekMusteri!.CompanyName;
           
            _db.Customers.Remove(silinecekMusteri);

            _db.SaveChanges();

            Listele();

            MessageBox.Show(txtId.Text + " IDli " + tanim + " isimli musterilerden silindi!");
        
    }
    }
}