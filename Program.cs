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
            detaillist.Add(new Detail("Vishal","Dute","dute0987@gmail.com","+91 8978776889"));
            foreach (Detail detail in detaillist)
            {
                //Console.WriteLine("First Name: " + detail.FirstName);
                //Console.WriteLine("Last name : " + detail.LastName);
                //Console.WriteLine("Email ID :"+ detail.Email);
                Console.WriteLine("Phone Number : " + detail.PhoneNumber);
            }
        }
    }
}
