namespace Namespace.Models;
public class ListaDeTarefas
{
    public List<Tarefa>? Tarefas { get; set; } = new();

    public bool AddTask(Tarefa tarefa){
        try
        {
            Tarefas.Add(tarefa);
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    public bool RemoveTask(Tarefa tarefa){
        try
        {
            Tarefas.Remove(tarefa);
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    public List<Tarefa> ListTask(){
        try
        {
            return Tarefas;
        }
        catch (System.Exception)
        {
            return null;
        }
    }
}
