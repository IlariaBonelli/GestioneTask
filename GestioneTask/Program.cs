using System;
using System.IO;
namespace GestioneTask
{
    class Program

    {
        private static TaskManager taskmanager = new TaskManager();
        
        static void Main(string[] args)

        {
            char livello = ;//valore ritornato dalla funzione ScegliLivello

            Console.WriteLine("Gestisci le tue attività");

            do
            {
                Console.WriteLine(); //lascio uno spazio per visualizzazione più chiara
                Console.WriteLine("1.Visualizza le attività in programma");
                Console.WriteLine("2.Inserisci una nuova attività");
                Console.WriteLine("3.Elimina un'attività");
                Console.WriteLine("4.Filtra le attività per importanza");
                Console.WriteLine("5.Salva");
                Console.WriteLine("0.Esci");

                switch (Console.ReadKey().KeyChar) //metto Char per evitare conflitto con tastierino
                {
                    case '1':
                        VisualizzaTask();
                        break;
                    case '2':
                        NuovoTask();
                        break;
                    case '3':
                        EliminaTask();
                        break;
                    case '4':
                        FiltroTask();
                        break;
                    case '5':
                        Salva();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }

            } while (true);
        }

        private static void Salva()
        {
            const string fileName = @"tasks.txt";
            const Formato formato = Formato.CSV;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(taskmanager.OttieniElenco(formato));  
            }
        }

        private static void FiltroTask()
        {
            //dovrò fare un ciclo sui values nel dictionary e poi foreach(attività t in _attività.Values
           
        }

        private static void EliminaTask()
        {
            throw new NotImplementedException();

        }


        private static void NuovoTask()
        {
            Console.WriteLine("\nDescrizione dell'attività: ");
            do
            {
                Console.WriteLine("\nData di scadenza: ");

            } while (!DateTime.TryParse(Console.ReadLine(), out id));

           
        }

            
        private static Livello ScegliLivello() 
            {     
                Console.WriteLine("\nLivello di importanza: (basso, medio, alto) ");
            do
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.B:
                        return Livello.B;
                    case ConsoleKey.M:
                        return Livello.M;
                    case ConsoleKey.A:
                        return Livello.A


            } while (true);


            Attività t = taskmanager.CreaTask(Console.ReadLine()); //fa riferimento al CreaTask in TaskManager
        }

        private static void VisualizzaTask()
        {
           Console.WriteLine();
           Console.WriteLine("Ecco le attività presenti");
           Console.WriteLine(taskmanager.OttieniElenco(Formato.Plain));
        }
    }
}
