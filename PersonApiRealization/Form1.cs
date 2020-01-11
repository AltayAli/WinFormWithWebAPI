using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PersonApiRealization.Models;
using PersonApiRealization.Operations.RESTServiceOperations;
using PersonApiRealization.Operations.SimpleOperations;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace PersonApiRealization
{
    public partial class Form1 : Form
    {

        PersonCRUDOperation operation;
        int DeletableID { get; set; }
        public Form1()
        {
            InitializeComponent();
            operation = new PersonCRUDOperation();
            
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            ModelBinding<PersonModel> modelBinding = new ModelBinding<PersonModel>(InsertOperationGroupBox);
            PersonModel model =  modelBinding.BindimgOperation();
            var response = await operation.InsertOperation(model);
            insert_status.Text = response.Content;
            LoadDataGridView();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txt_update_id.Text);
            ModelBinding<PersonModel> binding = new ModelBinding<PersonModel>(UpdateOperationGroupBox);
            var model = binding.BindimgOperation();
             var response= await operation.UpdateOperation(id,model);
            update_status.Text = response.Content;
            await LoadDataGridView();
            UpdateOperationGroupBox.Enabled = false;
            txt_update_id.Text = String.Empty;
            txt_update_Name.Text = String.Empty;
            txt_update_Surname.Text = String.Empty;
            txt_update_Email.Text = String.Empty;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataGridView();
           
        }

        private  void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOperationGroupBox.Enabled = true;
            txt_update_id.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            txt_update_Name.Text= dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            txt_update_Surname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            txt_update_Email.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
        }
        private async Task LoadDataGridView()
        {
            var source = await operation.GetAllElementsOperation();
            var model = JsonConvert.DeserializeObject(source.Content);
            dataGridView1.DataSource = model;
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
          DeletableID  =Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
          var status = await operation.DeleteOperation(DeletableID);
          deleted_status.Text = status.Content;
          await  LoadDataGridView();
            txt_update_id.Text = String.Empty;
            txt_update_Name.Text = String.Empty;
            txt_update_Surname.Text = String.Empty;
            txt_update_Email.Text = String.Empty;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DeletableID = 0;
        }
    }
}
