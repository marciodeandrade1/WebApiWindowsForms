
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
            _apiClient = new ApiClient("http://localhost:5001");

            // Configuração do componente DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produtosBindingSource;
        }

        private async void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                var produtos = await _apiClient.GetProdutosAsync();
                _produtosBindingSource.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoProduto = new Produto
                {
                    Nome = txtNome.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    Estoque = int.Parse(txtEstoque.Text)
                };

                var produtoAdicionado = await _apiClient.AddProdutoAsync(novoProduto);
                MessageBox.Show($"Produto adicionado com ID: {produtoAdicionado.Id}");

                // Recarregar a lista
                await CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");

            }
        }

        private async Task CarregarProdutos()
        {
            var produtos = await _apiClient.GetProdutosAsync();
            _produtosBindingSource.DataSource = produtos;
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Produto produtoSelecionado)
            {
                try
                {
                    produtoSelecionado.Nome = txtNome.Text;
                    produtoSelecionado.Preco = decimal.Parse(txtPreco.Text);
                    produtoSelecionado.Estoque = int.Parse(txtEstoque.Text);

                    await _apiClient.UpdateProdutoAsync(produtoSelecionado.Id, produtoSelecionado);
                    MessageBox.Show("Produto atualizado com sucesso!");

                    // Recarregar a lista
                    await CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar produto: {ex.Message}");
                }
            }
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Produto produtoSelecionado)
            {
                try
                {
                    await _apiClient.DeleteProdutoAsync(produtoSelecionado.Id);
                    MessageBox.Show("Produto removido com sucesso!");

                    // Recarregar a lista
                    await CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover produto: {ex.Message}");
                }
            }
        }
    }
}
