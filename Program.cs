using System;
using System.Collections.Generic;
using static Challenge2.IAnimal;

namespace  Challenge2;


public class Program
{
    public static void Main(string[] args)
    {
        NewMethod();
    

    }

        private static void NewMethod()//przy zalozeniu ze przekazemy interface mozemy podstawic emp2
        {
            var emp1 =new SavedEmployee("Cezary");
            var emp2 =new InMemoryEmp("Kzysiek");
            emp1.GradeAdded += OnGradeAdded;            //+= -dodak kolejne wywolanie do zdarzenia
            emp2.GradeAdded += OnGradeAdded;   

            while (true)
            {
                Console.WriteLine($"MENU 1-Wpisz ocene dla {emp1.Name} 2-Wpisz ocene dla {emp2.Name} 3-statystyka dla {emp1.Name} 4-statystyka dla {emp2.Name} q-wyjscie z programu");
                string input = Console.ReadLine();
                if (input == "q")  break; 
                 switch(input)
                {
                    case "1":
                        Console.WriteLine("Wpisz ocene:");
                        try
                        {
                            emp1.AddGrade(double.Parse(Console.ReadLine()));
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Niewlasciwy format" +ex);
                        }
                        break;
                     case "2":
                        Console.WriteLine("Wpisz ocene:");
                        try
                        {
                            emp2.AddGrade(double.Parse(Console.ReadLine()));
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Niewlasciwy format" +ex);
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Statystyka :{emp1.Name}");    
                        ShowStat(emp1);
                        break;
                    case "4":
                        Console.WriteLine($"Statystyka :{emp2.Name}");  
                        ShowStat(emp2);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;

              
                }
            }
        Console.WriteLine("Zakonczenie programu");

    }
        static void ShowStat(EmployeeBase em)
        {
            var stat = em.GetStatistics();

            Console.WriteLine("najwyzsza ocena to: " + stat.High);
            Console.WriteLine("najnizsza ocena to: " + stat.Low);
            Console.WriteLine("srednia to: " + stat.Avreage);
            Console.WriteLine("litera to: " + stat.Letter);
        }


        static void OnGradeAdded(object sender,EventArgs args)
        {
            Console.WriteLine($"New grade is added");
        }
        static void OnCheckGrade(object sender,EventArgs args)
        {
            Console.WriteLine($"Oho, The grade below 3");
        }


}

//     public static void zadanie()
//     {
//         StudentFile sf1=new StudentFile("Cezary");
//         StudentMemory sm1=new StudentMemory("Krzysiek");
  


//         while(true)
//         {
//             //Console.WriteLine("MENU 1-wpisz ocene dla "+sf1.name +" 2-wpisz ocene dla "+sm1.name + " q-zakonczenie programu" + "3-pokaz stat dla "+sf1.name + "4-pokaz stat dla: "+sm1.name );
//             Console.WriteLine($"MENU 1-wpisz ocene dla {sf1.name} 2-wpisz ocene dla {sm1.name} q-zakonczenie programu 3-pokaz stat dla {sf1.name} 4-pokaz stat dla: {sm1.name} ");
            
//             string input  = Console.ReadLine();
//             string g="";
//             if(input=="q")break;
//             switch(input)
//             {
//                 case "1":
//                 Console.WriteLine("Wpisz ocene:");
//                 sf1.AddGrade(Console.ReadLine());
//                 break;
//                 case "2":
//                 Console.WriteLine("Wpisz ocene:");
//                 g=Console.ReadLine();
//                 sm1.AddGrade(g);
//                 break;
//                 case "3":
//                 Console.WriteLine("Statystyka dla :"+sf1.name);
//                 sf1.ShowStat();
//                 break;
//                  case "4":
//                 Console.WriteLine("Statystyka dla :"+sm1.name);
//                 sm1.ShowStat();
//                 break;
//             }

//         }
        
//     }     
// }



//--------------------------------------------------------------------

       
//        var emp1 =new SavedEmployee("Cezary");
//        var emp2 =new InMemoryEmp("Kzysiek");
//         emp1.GradeAdded += OnGradeAdded;            //+= -dodak kolejne wywolanie do zdarzenia


//         NewMethod(emp2);//to mzemy przekazac kazdego pracownika ktory implementuje iEmployee
//         emp2.ShowStat();
        
//         // var stat = emp1.GetStatistics();

//         // Console.WriteLine("najwyzsza ocena to: " + stat.High);
//         // Console.WriteLine("najnizsza ocena to: " + stat.Low);
//         // Console.WriteLine("srednia to: " + stat.Avrage);
//         // Console.WriteLine("litera to: " + stat.Letter);
//     }

//     private static void NewMethod(IEmployee emp2)//przy zalozeniu ze przekazemy interface mozemy podstawic emp2
//     {
//         while (true)
//         {
//             Console.WriteLine($"Podaj ocene dla: {emp2.Name} mistrza programowania");
//             string input = Console.ReadLine();
//             if (input == "q")
//             {
//                 break;
//             }
//             try
//             {
//                 double grade = double.Parse(input);
//                 emp2.AddGrade(grade);
//             }
//             catch (FormatException ex)
//             {
//                 Console.WriteLine(ex.Message);//hej,wprowadziles neprawidlowy format
//             }
//             catch (ArgumentException ex)
//             {
//                 throw new ArgumentException($"invalid parameter ex, it should be 0-100 {nameof(input)}");
//             }
//             Console.WriteLine("lalal");
//         }
//     }

//     static void OnGradeAdded(object sender,EventArgs args)
//     {
//         Console.WriteLine($"New grade is added");
//     }
//       static void OnCheckGrade(object sender,EventArgs args)
//     {
//         Console.WriteLine($"Oho, The grade below 3");
//     }

//   }

//--------------------------------------------------------------------

  
        //var ZadDom=new ZadDomowe();
        //ZadDom.zad12();















        // var grades =new List<double>(){12.4,5,0.333};
        // var employee1=new Employee("Cezary");
        // employee1.AddGrade(5.3);
        // employee1.AddGrade(12.4);
        // employee1.AddGrade(5);
        // employee1.AddGrade(0.333);

        // employee1.AddGrade2("4");

        // var stat=employee1.GetStatistic();
        // employee1.SetName2(ref employee1,"czarek1");

        // Console.WriteLine("Hello, World5! "+stat);

        // var ZadDom=new ZadDomowe();
        // ZadDom.zad11();
        // Console.WriteLine("wynik to: "+ZadDom.test1(70));
       
 









