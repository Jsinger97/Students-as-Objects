using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of students
            Degree[] degrees = new Degree[6];
            //create new objects
            degrees[0] = new Degree("Forensic Psychology");
            degrees[0].StudentId = 13445567;
            degrees[0].StudentName = "Annie Connoly";
            degrees[1] = new Degree("Molecular Biology");
            degrees[1].StudentName = "Milly Smith";
            degrees[1].StudentId = 13457789;
            degrees[2] = new Degree("Graphics Design and Art Direction");
            degrees[2].StudentName = "Ellie Hilton";
            degrees[2].StudentId = 13476678;
            degrees[3] = new Forensics("Forensic Science");
            degrees[4] = new Biology("Wildlife Biology");
            degrees[5] = new Graphics("Graphics Desighn");
            for (int i = 0; i < 6; i++)
            {   //Print out onto colsole in given format using getsummery
                Console.WriteLine(degrees[i].getsummmery);
            }
        }
    }
}
