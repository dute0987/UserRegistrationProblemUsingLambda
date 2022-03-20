using System;
namespace UserRegistrationUsingLambda
{
    class Program
    {
        public static void Main(string[]args)
        {
            List<Detail> detaillist = new List<Detail>();
            AddRecords(detaillist);
            
        }
        private static void AddRecords(List<Detail> detaillist)
        {
            detaillist.Add(new Detail("Vishal"));
            foreach (Detail detail in detaillist)
            {
                Console.WriteLine("First Name: " + detail.FirstName);
            }
        }
    }
}
