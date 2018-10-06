using System;
using System.IO;
using System.Text;
// ReSharper disable InvalidXmlDocComment
// ReSharper disable StringLiteralTypo
// ReSharper disable All

namespace EGE // Наговицын Дмитрий HW5 Task 4
{

    class Program
    {
        static void Main(string[] args)
        {

            int gradesnumber = 3; // кол-во оценок для учеников 
            string pathname = "data.txt"; // файл данных
            int worstgrades = 3;    // кол-во худших средних оценок, учеников получивших которые нужно вывести на экран
            Pupil[] pupils;
            
            string outputMessage = InputPupils(gradesnumber, pathname, out pupils);
            if (pupils != null)
            {
                Console.WriteLine(outputMessage);
                PrintListOfPupils(pupils, "Все ученики:");

                Pupil[] loosers = Pupil.GetWorstPupils(pupils, worstgrades);
                PrintListOfPupils(loosers, $"Ученики с {worstgrades} самими худшими оценками:");
                Console.ReadKey();
            }
            else Console.WriteLine(outputMessage);

            Console.ReadKey();
        }

        private static void PrintListOfPupils(Pupil[] pupils, string str)
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(str);
            Console.WriteLine("_______________________________________________");
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine(pupils[i].ToString());
            }
        }

        private static string InputPupils(int gradesnumber, string pathname, out Pupil[] pupils)
        {
            string[] inputArray = new string[gradesnumber + 2];
            int[] grades = new int[gradesnumber];
            StreamReader sr;
            string input = string.Empty;
            StringBuilder outputMessage = new StringBuilder();

            if (File.Exists(pathname))
                sr = new StreamReader(pathname);
            else
            {
                pupils = null;
                return "Нет файла";
            }
            if (!Int32.TryParse(sr.ReadLine(), out int pupilCount))
            {
                pupils = null;
                return "Не верный формат файла";
            }
            if (pupilCount > 100 || pupilCount < 10)
            {
                pupils = null;
                return "В файле не достаточно даннных для ввода";
            }

            pupils = new Pupil[pupilCount];
            for (int i = 0; i < pupilCount; i++)
            {
                grades = new int[gradesnumber];
                input = sr.ReadLine();
                inputArray = input.Split(' ');
                if (inputArray.Length == gradesnumber + 2)         // проверка формата строки
                {
                    for (int j = 0; j < gradesnumber; j++)
                    {
                        if (Pupil.CheckGradesFormat(inputArray[j + 2]))    //проверка формата оценок
                        {
                            grades[j] = Convert.ToInt32(inputArray[j + 2]);
                        }
                        else
                        {
                            outputMessage.Append($"Данные об ученике {inputArray[0]} {inputArray[1]} не корректны и не считаны\n");
                            grades = null;
                            pupilCount--;
                            i--;
                            break;
                        }
                    }
                    if (grades != null)
                    {
                        pupils[i] = new Pupil(inputArray[0], inputArray[1]);
                        pupils[i].GradesInput(grades);
                    }
                }
                else
                {
                    pupilCount--;
                    i--;
                    outputMessage.Append($"не верный формат строки: {input}\n");
                }
            }
            sr.Close();
            Array.Resize(ref pupils, pupilCount);
            return Convert.ToString(outputMessage);
        }
    }
}
