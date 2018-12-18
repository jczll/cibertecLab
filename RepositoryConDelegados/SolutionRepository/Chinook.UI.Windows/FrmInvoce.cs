using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Entities.Base;
using Chinook.DataAcces.Interface;
using Chinook.DataAcces.Repository;
using Chinook.DataAcces.Queries;
using static Chinook.UI.Windows.Eventos.Listeners;

namespace Chinook.UI.Windows
{
    public partial class FrmInvoce : Form
    {
        private readonly DbContext dbcontext;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        List<DetalleInvoice> detalleInvoice = new List<DetalleInvoice>();
        //List<Customer> CustomerList = new List<Customer>();
        public FrmInvoce()
        {
            this.dbcontext = new Model1();
            invoiceRepository = new InvoiceRepository(dbcontext);
            customerRepository = new CustomerRepository(dbcontext);
            unitOfWork = new UnitOfWork(dbcontext);
            InitializeComponent();
        }
        private void FrmInvoce_Load(object sender, EventArgs e)
        {
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.ReadOnly = true;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.AutoGenerateColumns = false;
            HabilitaBotonAgregaTracks();
            GetAllCustomer();
        }
        public void BuscarCustomer(int iCustomerID)
        {
            var listado = unitOfWork.InvoiceRepository.GetCustosmerId_Invoice(iCustomerID);
            if (listado.Count() > 0)
                foreach (var item in listado)
                {
                    txtBillingAdress.Text = item.BillingAddress;
                    txtBillingCity.Text = item.BillingCity;
                    txtBillingCountry.Text = item.BillingCountry;
                    txtBillingState.Text = item.BillingState;
                    txtBillingPostalCode.Text = item.BillingPostalCode;
                }
        }
        private void btnBuscarTracks_Click(object sender, EventArgs e)
        {
            try
            {
                var frmTracks = new FrmTracks();
                //AddOwnedForm(frmTracks);
                frmTracks.onAfterSelectedItem += new AfterSelectedItemHandler(LlenaTracks);
                frmTracks.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void LlenaTracks(Object obj)
        {
            var trackNameQuery = (TrackNameQuery)obj;
            txtTrackName.Tag = trackNameQuery.TrackId;
            txtTrackName.Text = trackNameQuery.Track_name;
            txtUnitPrice.Text = trackNameQuery.UnitPrice.ToString();
            txtQuantity.Text = "1";
            HabilitaBotonAgregaTracks();
        }
        private void btnAgregaTracks_Click(object sender, EventArgs e)
        {
            AgregaTracksText();
        }
        public void AgregaTracksText()
        {
            if (ValidaAgregarDetalle(txtTrackName.Text))
            {
                detalleInvoice.Add(new DetalleInvoice()
                {
                    TrackId = Convert.ToInt32(txtTrackName.Tag),
                    TrackName = txtTrackName.Text,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text)
                });
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = detalleInvoice;
                //dgvDetalle.Rows.Add(txtTrackName.Tag, txtTrackName.Text, txtQuantity.Text.ToString(), txtUnitPrice.Text.ToString());
                dgvDetalle.Refresh();
                txtTotal.Text = Convert.ToString(SumaDetalle());
                txtTrackName.Tag = "";
                txtTrackName.Text = "";
                txtUnitPrice.Text = "";
                txtQuantity.Text = "";
                HabilitaBotonAgregaTracks();
            }
            else
                MessageBox.Show("Ya existe esa Pista en la Lista ");
        }
        public bool ValidaAgregarDetalle(string sTrackName)
        {
            try
            {
                int iCount = 0;
                bool bSalida = true;
                while (iCount < dgvDetalle.RowCount && bSalida)
                {
                    if (Convert.ToString(dgvDetalle.Rows[iCount].Cells[1].Value) == sTrackName)
                    {
                        bSalida = false;
                        break;
                    }
                    iCount++;
                }
                return bSalida;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public double SumaDetalle()
        {
            int iCount = 0;
            double dTotalPrecio=0;
            while (iCount < dgvDetalle.RowCount)
            {
                int iQuantity = Convert.ToInt32(dgvDetalle.Rows[iCount].Cells[2].Value);
                double dUnitPrice = Convert.ToDouble(dgvDetalle.Rows[iCount].Cells[3].Value);
                dTotalPrecio = dTotalPrecio+(iQuantity*dUnitPrice);
                iCount++;
            }
            return dTotalPrecio;
        }
        public int GuardaInvoce()
        {
            var invoice = new Invoice();
            invoice.CustomerId = Convert.ToInt32(cmbCustomer.Tag);
            invoice.InvoiceDate = Convert.ToDateTime(dtpInvoiceDate.Text);
            invoice.BillingAddress = txtBillingAdress.Text;
            invoice.BillingCity = txtBillingCity.Text;
            invoice.BillingState = txtBillingState.Text;
            invoice.BillingCountry = txtBillingCountry.Text;
            invoice.BillingPostalCode = txtBillingPostalCode.Text;
            //Agregando Items
            int iCount = 0;
            while (iCount < dgvDetalle.RowCount)
            {
                int iTrackId = Convert.ToInt32(dgvDetalle.Rows[iCount].Cells[0].Value);
                if(iTrackId>0)
                {
                    invoice.InvoiceLine.Add(
                        new InvoiceLine()
                        {
                            TrackId = iTrackId,
                            Quantity = Convert.ToInt32(dgvDetalle.Rows[iCount].Cells[2].Value),
                            UnitPrice = Convert.ToDecimal(dgvDetalle.Rows[iCount].Cells[3].Value)
                        }
                    );
                }
                iCount++;
            }
            //Sumando Totales 
            invoice.Total = invoice.InvoiceLine.Sum(item => item.UnitPrice * item.Quantity);
            unitOfWork.InvoiceRepository.Add(invoice);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            return invoice.InvoiceId;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardaInvoce()>0)
                MessageBox.Show("La Factura Fue Guardada en forma Satisfactoria", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar La Factura ", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void HabilitaBotonAgregaTracks()
        {
            if(txtTrackName.Text=="" || txtQuantity.Text == "" || txtUnitPrice.Text == "")
            {
                btnAgregaTracks.Enabled = false;
                btnBuscarTracks.Enabled = true;
            }
            else
            {
                btnAgregaTracks.Enabled = true;
                btnBuscarTracks.Enabled = false;
            }
        }
        public void QuitarTrack()
        {
            DialogResult cRespuesta = MessageBox.Show("Desea Realmente Eliminar El Registro ", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cRespuesta == DialogResult.Yes)
            {
                var TrackId = Convert.ToInt32(dgvDetalle.SelectedRows[0].Cells["ClmTrackId"].Value);
                var TrackEncontrado = detalleInvoice.Where(item => item.TrackId == TrackId).FirstOrDefault();
                detalleInvoice.Remove(TrackEncontrado);
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = detalleInvoice;
                dgvDetalle.Refresh();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarTrack();
        }
        //public void GetById()
        //{
        //    var album = customerRepository.GetById(1);
        //    //Assert.IsTrue(album.AlbumId > 0, "Ok");
        //}
        public void GetAllCustomer()
        {
            var listado = customerRepository.GetAll();
            if (listado.Count() > 0)
                foreach (var item in listado)
                {
                    cmbCustomer.Items.Add(item.CustomerId.ToString()+" "+item.FirstName+" "+item.LastName);
                }
            cmbCustomer.Refresh();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indice = cmbCustomer.SelectedIndex;
            //txtCustomerID.Text=cmbCustomer.Items[indice].ToString();
            string cadena = cmbCustomer.SelectedItem.ToString();
            cmbCustomer.Tag = cadena.Substring(0, 2);
            BuscarCustomer(Convert.ToInt32(cadena.Substring(0, 2)));
        }
    }
}
