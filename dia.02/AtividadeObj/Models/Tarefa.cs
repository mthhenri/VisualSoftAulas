namespace Namespace.Models;
public class Tarefa
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public bool CreateTask(string TarefaNome, string DescricaoTexto)
    {
        try
        {
            Nome = TarefaNome;
            Descricao = DescricaoTexto;
            Concluida = false;

            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    public bool ConcludeTask()
    {
        try
        {
            Concluida = true;

            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }
}
