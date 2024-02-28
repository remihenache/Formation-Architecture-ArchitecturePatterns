namespace ArchitecturePatterns.MVC;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nGestionnaire de Tâches:");
            Console.WriteLine("1. Ajouter une tâche");
            Console.WriteLine("2. Afficher les tâches");
            Console.WriteLine("3. Supprimer une tâche");
            Console.WriteLine("4. Quitter");
            Console.Write("Choisissez une option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Entrez la tâche: ");
        var task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Tâche ajoutée.");
    }

    static void ShowTasks()
    {
        Console.WriteLine("\nTâches:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void DeleteTask()
    {
        ShowTasks();
        Console.Write("Entrez le numéro de la tâche à supprimer: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Tâche supprimée.");
        }
        else
        {
            Console.WriteLine("Numéro de tâche invalide.");
        }
    }
}