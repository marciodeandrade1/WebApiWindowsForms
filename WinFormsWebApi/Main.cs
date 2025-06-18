namespace WinFormsWebApi
{
    public partial class Main : Form
    {
        private readonly ApiClient _apiClient;
        private BindingSource _produtosBindingSource = new BindingSource();
        public Main()
        {
            InitializeComponent();
            //Url da API
            _apiClient = new ApiClient("https://localhost:5001");

            // Configuração do componente DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produtosBindingSource;
        }
    }
}
