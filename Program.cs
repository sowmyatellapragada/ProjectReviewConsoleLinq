using System;
using System.Collections.Generic;
namespace ProjectReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Management management = new Management();
            Console.WriteLine("Welcome to ProjectManagement ");

            String entrance = "yes";
            ProjectReviewList Project = new ProjectReviewList();

            while (entrance.Equals("yes"))
            {
                Console.WriteLine("1.RetrieveCountOfProjectType: .       2.SelectedProjects.         3.TopProjects. 4.exit.");
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {

                        case 1:
                            Console.WriteLine("RetrieveCountOfProjectType");
                            Management.RetrieveCountOfProjectType(ProjectReviewList.Retrieve());
                            Console.WriteLine("=================================");
                            break;
                        case 2:
                            Console.WriteLine("SelectedProjects");
                            Management.SelectedProjects(ProjectReviewList.Retrieve());
                            Console.WriteLine("==================================");
                            break;
                        case 3:
                            Console.WriteLine("TopProjects");
                            Management.TopProjects(ProjectReviewList.Retrieve());
                            break;
                        case 4:
                            entrance = "no";
                            Console.WriteLine("Thankyou ");
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("please, Enter valid choice .");
                }
                
            }
        }
    }
}
