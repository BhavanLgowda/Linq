namespace LinqSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The list of query:");

            Console.WriteLine("1.Select query");
            Console.WriteLine("2.Orderby and thenby");
            Console.WriteLine("3.aggregate");
            Console.WriteLine("4.Take and Skip");
            Console.WriteLine("5.Join\n");

            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                        //Using select
                         var result = from student in Student.GetAllStudents()
                         select student;
                        foreach (Student s in result)
                        {
                           Console.WriteLine(s.StudentId + " " + s.Name + " " + s.TotalMarks);
                        }
                  break; ;
                case 2:
                      // Orderby and thenby Query
                      IEnumerable<Student> result1 = from student in Student.GetAllStudents()
                                                     orderby student.TotalMarks, student.Name, student.StudentId descending
                                                     select student;
                      //var result = Student.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s => s.StudentId);

                            foreach (Student s in result1)
                            {
                              Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentId);
                            }
                  break;
                case 3:
                    //Using aggregate
                    string[] list = { "One", "Two", "Three", "Four", "Five" };

                    var commaSeperatedString = list.Aggregate((s1, s2) => s1 + ", " + s2);

                    Console.WriteLine(commaSeperatedString);
                    break;
                case 4:
                    //Skip and take query
                    string[] Countries = { "Australia", "Italy", "India", "Us", "Germany", "Uk" };

                   //IEnumerable<string> result = Countries.Skip(2);
                   //IEnumerable<string> result = Countries.Take(2);
                   //IEnumerable<string> result = Countries.TakeWhile(s => s.Length > 2);
                   // IEnumerable<string> result = Countries.SkipWhile(s => s.Length > 2);

                    IEnumerable<string> result2 = (from country in Countries
                                                 select country).SkipWhile(s => s.Length > 2);
                    foreach(string str in result2)
                    {
                        Console.WriteLine(str);
                    }
                    break;
                case 5:
                    string[] counts = { "Australia", "Italy", "One", "Two", "Three", "Four", "Five" };
                    string[] Country = { "Australia", "Italy", "India", "Us", "Germany", "Uk" };

                    var innerJoin = counts.Join(Country,
                                                counts => counts,
                                                Country => Country,
                                               (counts, country) => counts);

                    foreach (var str in innerJoin)
                    {
                        Console.WriteLine("{0} ", str);
                    }
                    break;
            }
        }
    }
}