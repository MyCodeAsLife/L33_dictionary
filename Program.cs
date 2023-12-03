using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L33_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Офигенный план, надежный как швейцарские часы
            Dictionary<string, string> tenYearPlan = GetPlan();

            WorkWithPlan(tenYearPlan);
        }

        private static void WorkWithPlan(Dictionary<string, string> tenYearPlan)
        {
            const string CommandPlan = "План";
            const string CommandExit = "Выход";

            bool isOpen = true;

            while (isOpen)
            {
                Console.Write($"План на ближайшие 10 лет.\n\nЧтобы показать весь план введите: {CommandPlan}\n" +
                              $"Чтобы выйти введите: {CommandExit}\nЧтобы просмотреть конкретный участок, " +
                              $"введите его наименование.\n\nЧто вам показать?: ");
                string userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case CommandPlan:
                        WriteAll(tenYearPlan);
                        break;

                    case CommandExit:
                        isOpen = false;
                        continue;

                    default:
                        WriteValue(tenYearPlan, userInput);
                        break;
                }

                Console.WriteLine("Для продолжения нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static Dictionary<string, string> GetPlan()
        {
            Dictionary<string, string> tempPlan = new Dictionary<string, string>();

            tempPlan.Add("Мотивация", "Побуждение к действию; психофизиологический процесс, управляющий " +
                "поведением человека, задающий его направленность, организацию, активность и устойчивость; " +
                "способность человека деятельно удовлетворять свои потребности");
            tempPlan.Add("Обучающие курсы", "Образовательное мероприятие, направленное на удовлетворение " +
                "познавательных потребностей слушателей в определенной сфере профессиональной деятельности или области знаний.");
            tempPlan.Add("Ментор", " О ком-л., постоянно поучающем, настаивающем, навязчиво воспитывающем");
            tempPlan.Add("Программист", "Специалист, занимающийся программированием компьютерных программ");
            tempPlan.Add("Галера", "Гребное многовёсельное военное судно, на котором гребцами были рабы, каторжники или пленные");
            tempPlan.Add("Профессиональная деформация", "Когнитивное искажение, психологическая " +
                "дезориентация личности, формирующаяся из-за постоянного давления внешних и внутренних " +
                "факторов профессиональной деятельности и приводящая к формированию специфически-профессионального типа личности");
            tempPlan.Add("Выгорание", "Cостояние эмоционального, умственного истощения, физического утомления, " +
                "возникающее в результате хронического стресса на работе");
            tempPlan.Add("Геморрой", "Это заболевание, которое характеризуется варикозным расширением вен и появлением " +
                "венозных (геморроидальных) узлов в нижней части прямой кишки");
            tempPlan.Add("Запор", "Нарушение процесса дефекации, проявляющиеся в отсутствии стула больше " +
                "2-3-х суток или неполноценном опорожнении кишечника");
            tempPlan.Add("Импотенция", "Патологическое состояние, которое характеризуется невозможностью " +
                "достижения или же поддержания полового члена в эрегированном состоянии");

            return tempPlan;
        }

        private static void WriteValue(Dictionary<string, string> dictionary, string element)
        {
            if (dictionary.ContainsKey(element))
                Console.WriteLine(dictionary[element]);
            else
                Console.WriteLine("В плане нет такого пункта.");

            Console.WriteLine();
        }

        private static void WriteAll(Dictionary<string, string> dictionary)
        {
            foreach (var value in dictionary)
                Console.WriteLine($"{value.Key} - {value.Value}\n");

            Console.WriteLine();
        }
    }
}
