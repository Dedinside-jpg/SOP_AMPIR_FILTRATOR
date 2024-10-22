using CsvHelper;
using System.DirectoryServices;

namespace SOP_AMPIR_FILTRATOR
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}


namespace WindowsFormsApp1
{
    public class Members
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }

        public List<Members> AllMmbrs()
        {
            StreamReader streamReader = File.OpenText(@"pass");
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            List<Members> members = new List<Members>();
            while (csvReader.Read())
            {
                var Members = new Members
                {
                    Name = csvReader.GetField(1).ToString(),
                    Age = int.Parse(csvReader.GetField(3)),
                    Gender = csvReader.GetField(2).ToString(),
                    Birthday = csvReader.GetField(4).ToString(),
                    PhoneNumber = csvReader.GetField(5).ToString(),
                    Faculty = csvReader.GetField(6).ToString(),
                    Course = int.Parse(csvReader.GetField(7)),
                    Group = int.Parse(csvReader.GetField(8)),
                };
                AllMmbrs.Add(Members);

            }
            return AllMmbrs;
        }

    }
}

namespace WindowsFormsApp1
{
    public class Requests
    {
        public List<Members> AgeSorting(List<Members> AllMmbrs, int Age)
        {


            List<Members> RightMemb = new List<Members>();
            foreach (var mem in AllMmbrs)
            {
                if (Age == mem.Age)
                {
                    RightMemb.Add(mem);
                }
            }
            return RightMemb;
        }

        public List<Members> FacultySorting(List<Members> AllMmbrs, string Faculty)
        {


            List<Members> RightMemb = new List<Members>();
            foreach (var mem in AllMmbrs)
            {
                if (Faculty == mem.Faculty)
                {
                    RightMemb.Add(mem);
                }
            }
            return RightMemb;
        }
        public List<Members> CourseSorting(List<Members> AllMmbrs, int Course)
        {


            List<Members> RightMemb = new List<Members>();
            foreach (var mem in AllMmbrs)
            {
                if (Course == mem.Course)
                {
                    RightMemb.Add(mem);
                }
            }
            return RightMemb;
        }

    }
}

