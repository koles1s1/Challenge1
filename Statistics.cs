namespace Challenge2
{
    public class Statistics
    {
        public double High;
        public double Low;
        public double Sum;
        public double Count;
        public Statistics()
        {
            Sum=0.0;
            Count=0.0;
            Low=Double.MaxValue;
            High=Double.MinValue;
        }
        public double Avreage
        {
            get
            {
                return Sum/Count;
            }
        }
        public char Letter
        {
            get{
            switch (Avreage)
            {
                case var a when a>80:
                return 'A';
                case var b when b>50 && b<80:
                return 'B';
                default:
                return 'Z';
            }
            }
        }

        public void Add(double numer)
        {
            High=Math.Max(numer,High);
            Low =Math.Min(numer,Low);
            Sum+=numer;
            Count++;

        }
        
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