using Microsoft.Maui.Controls;
using Fluxograma.Modelos;
namespace Fluxograma
{
    public partial class CadastroPage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public Fluxograma.Modelos.Cliente cliente = new Fluxograma.Modelos.Cliente();

        public CadastroPage()
        {
            InitializeComponent();
        }

        private async void Salvar_Clicked(object sender, EventArgs e)
        {
            // Lógica para salvar os dados do cliente
            // ... (ex: enviar para um banco de dados)

            await DisplayAlert("Sucesso", "Cliente cadastrado com sucesso!", "OK");
            // Navegar para outra página ou fechar a modal
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            // Lógica para cancelar o cadastro
            // ... (ex: fechar a modal ou voltar para a página anterior)
        }
    }
}