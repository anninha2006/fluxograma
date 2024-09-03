using Fluxograma.Modelos;
using Fluxograma;

namespace Fluxograma;
public partial class ListaClientesPage : ContentPage
{
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
  Fluxograma.Modelos.Cliente cliente = new Fluxograma.Modelos.Cliente();

  public ListaClientesPage()
	{
		InitializeComponent();

    ListaClientes.ItemsSource = clienteControle.LerTodos();
	}

  void Josefina(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastroPage();
    page.cliente = e.SelectedItem as Fluxograma.Modelos.Cliente;
    Application.Current.MainPage = page;
  }

}
