using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppAgendaDeTarefas;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<String> listaTarefas = new List<String>();
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    /// <summary>
    /// funcionalidade inicial 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Adicionar_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TxtTarefa.Text))
        {
            ListaTarefas.Items.Add(TxtTarefa.Text);
            AdicionarTarefas();
            TxtTarefa.Clear();
        }
        else
        {
            MessageBox.Show("Digite uma tarefa válida!");
        }
    }
    private void Limpar_lista_Click(object sender, RoutedEventArgs e)
    {
        if (ListaTarefas.Items.Count > 0)
        {
            
            ListaTarefas.Items.Clear(); 
            
            MessageBox.Show("A lista foi limpa com sucesso!", "Limpeza");
        }
    }
    private void AdicionarTarefas()
    {
        string descricao = TxtTarefa.Text.Trim();

        if (!string.IsNullOrWhiteSpace(descricao))
        {
            listaTarefas.Add(descricao);
        }
    }
}