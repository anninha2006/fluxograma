using Microsoft.Maui.Controls;

namespace Quinquim
{
    public partial class StatusPage : ContentPage
    {
        public StatusPage()
        {
            InitializeComponent();
        }

        private void OnSairClicked(object sender, EventArgs e)
        {
            // Ação a ser executada quando o botão "Sair" for clicado
            // Por exemplo, fechar o aplicativo ou navegar para outra página
            Application.Current.Quit();
        }
    }
}