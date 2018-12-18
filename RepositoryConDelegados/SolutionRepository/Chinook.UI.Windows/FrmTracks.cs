using Chinook.DataAcces.Interface;
using Chinook.DataAcces.Queries;
using Chinook.DataAcces.Repository;
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
using static Chinook.UI.Windows.Eventos.Listeners;

namespace Chinook.UI.Windows
{
    public partial class FrmTracks : Form
    {
        private readonly DbContext dbcontext;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IUnitOfWork unitOfWork;
        public event AfterSelectedItemHandler onAfterSelectedItem;

        public FrmTracks()
        {
            this.dbcontext = new Model1();
            invoiceRepository = new InvoiceRepository(dbcontext);
            unitOfWork = new UnitOfWork(dbcontext);
            InitializeComponent();
        }

        private void FrmTracks_Load(object sender, EventArgs e)
        {
            dgvTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTracks.ReadOnly = true;
            dgvTracks.MultiSelect = false;
            dgvTracks.AutoGenerateColumns = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            var Listado = unitOfWork.InvoiceRepository.GetTrackName(txtBuscarTrack.Text);
            dgvTracks.DataSource = Listado;
            dgvTracks.Refresh();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var trackNameQuery = new TrackNameQuery();
            trackNameQuery.TrackId = Convert.ToInt32(dgvTracks.SelectedRows[0].Cells["ClmTrackId"].Value);
            trackNameQuery.Track_name = Convert.ToString(dgvTracks.SelectedRows[0].Cells["ClmTrackName"].Value);
            trackNameQuery.UnitPrice= Convert.ToDecimal(dgvTracks.SelectedRows[0].Cells["ClmUnitPrice"].Value);
            if (onAfterSelectedItem != null)
            {
                onAfterSelectedItem(trackNameQuery);
            }
            this.Close();
        }
    }
}
