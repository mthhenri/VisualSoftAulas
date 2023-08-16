using AtividadeObj.Models;
ListaDeTarefas listaTarefas = new();

int resp = 0;
Console.Clear();
do{
    GenerateMenu();
    Console.Write("\nIr para? ");
    resp = Convert.ToInt32(Console.ReadLine());
    switch(resp)
    {
        case 1:
            CreateTask();
            break;
        case 2:
            RemoveTask();
            break;
        case 3:
            ConcludeTask();
            break;
        case 4:
            ListTasks();
            break;
        case 5:
            break;
        default:
            break;
    }
} while (resp != 5);
Console.WriteLine("Desligando . . .");

static void GenerateMenu()
{
    Console.WriteLine("\n-=X Menu X=-");
    Console.WriteLine("1 - Criar Tarefa");
    Console.WriteLine("2 - Remover Tarefa");
    Console.WriteLine("3 - Concluir Tarefa");
    Console.WriteLine("4 - Listar Tarefas");
    Console.WriteLine("5 - Sair");
}

void CreateTask()
{
    Tarefa newTarefa = new();
    Console.WriteLine("\n-=X Criar Tarefa X=-");
    Console.Write("Título da tarefa: ");
    string? nomeTarefa = Console.ReadLine();
    Console.Write("Descrição da tarefa: ");
    string? descricaoTarefa = Console.ReadLine();
    try
    {
        newTarefa.CreateTask(nomeTarefa, descricaoTarefa);
        if(listaTarefas.AddTask(newTarefa)){
            Console.WriteLine("Tarefa criada!");
        } else {
            Console.WriteLine("Erro ao criar a tarefa!");
            return;
        }
    }
    catch (System.Exception error)
    {
        Console.WriteLine(error.ToString());
        return;
    }
}

void RemoveTask()
{
    Console.WriteLine("\n-=X Remover Tarefa X=-");
    if(listaTarefas.ListTask().Count == 0){
        Console.WriteLine("Não há nenhuma tarefa criada!");
    } else {
        try
        {
            int i = 1;
            foreach (Tarefa tarefa in listaTarefas.ListTask())
            {
                Console.WriteLine($"{i} - Tarefa: {tarefa.Nome} | Concluída? {tarefa.Concluida}");
                i++;
            }
            i = 1;
            Console.Write("\nDeseja remover qual? ");
            int remove = Convert.ToInt32(Console.ReadLine());
            foreach (Tarefa tarefa in listaTarefas.ListTask())
            {
                if(i == remove)
                {
                    try
                    {
                        listaTarefas.RemoveTask(tarefa);
                        Console.WriteLine("Tarefa removida!");
                        return;
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.ToString());
                        return;
                    }
                } else {
                    i++;
                }
            }

        }
        catch (System.Exception error)
        {
            Console.WriteLine(error.GetType());
        }
    }
}

void ConcludeTask()
{
    Console.WriteLine("\n-=X Concluir Tarefa X=-");
    if(listaTarefas.ListTask().Count == 0){
        Console.WriteLine("Não há nenhuma tarefa criada!");
    } else {
        try
        {
            int i = 1;
            foreach (Tarefa tarefa in listaTarefas.ListTask())
            {
                Console.WriteLine($"{i} - Tarefa: {tarefa.Nome} | Concluída? {tarefa.Concluida}");
                i++;
            }
            i = 1;
            Console.Write("\nDeseja concluir qual? ");
            int conclude = Convert.ToInt32(Console.ReadLine());
            foreach (Tarefa tarefa in listaTarefas.ListTask())
            {
                if(i == conclude)
                {
                    try
                    {
                        tarefa.ConcludeTask();
                        Console.WriteLine("Tarefa concluída!");
                        return;
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.ToString());
                        return;
                    }
                } else {
                    i++;
                }
            }
        }
        catch (System.Exception error)
        {
            Console.WriteLine(error.GetType());
        }
    }
}

void ListTasks()
{
    Console.WriteLine("\n-=X Listar Tarefas X=-");
    if(listaTarefas.ListTask().Count == 0){
        Console.WriteLine("Não há nenhuma tarefa criada!");
    } else {
        foreach (Tarefa tarefa in listaTarefas.ListTask())
        {
            Console.WriteLine($"Tarefa: {tarefa.Nome} | Concluída? {tarefa.Concluida}");
            Console.WriteLine($"Descrição: {tarefa.Descricao}\n");
        }
    }
}