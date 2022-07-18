namespace Challenge2
{
    public delegate void  GradeAddedDelegate(object sender,EventArgs args);
   
    public class NamedObject
    {
        public NamedObject(string name)
        {
            this.Name=name;
        }
        public string Name {get;set;}
    }
    public interface IEmployee
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name{get;}
        event GradeAddedDelegate GradeAdded;
    }


    public abstract  class EmployeeBase:NamedObject , IEmployee
    {
        public EmployeeBase(string name):base(name)
        {

        }
        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    
   
    }
    public class InMemoryEmp: EmployeeBase
    {
        public List<double> grades;
        public InMemoryEmp(string name):base(name)
        {
            grades=new List<double>();
        }
        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            if(grade>0 && grade<100)
            {
                grades.Add(grade);
                if(GradeAdded!=null)
                {
                    GradeAdded(this,new EventArgs());
                }
            }
            
        }
        public override Statistics GetStatistics()
        {
            Statistics s =new Statistics();
            for (int i = 0; i < grades.Count; i++)
            {
                s.Add(grades[i]);
            }
            return s;
        }
        public void ShowStat()
        {
            foreach (var item in grades)
            {   
                Console.WriteLine(item);
            }
        }

    }


    public class SavedEmployee : EmployeeBase
    {
        public SavedEmployee(string name) : base(name)
        {
        }
        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using(var writer = File.AppendText($"{Name}.txt"))
            {   
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this,new EventArgs());
                }
            }
            


            
        }

        public override Statistics GetStatistics()
        {
            var result=new Statistics();
            using(var rader = File.OpenText($"{Name}.txt"))
            {   
                var line=rader.ReadLine();
                while(line!=null)
                {
                    var number=double.Parse(line);
                    result.Add(number);
                    line=rader.ReadLine();
                }
            }
            return result;

        }
    }
}
    
