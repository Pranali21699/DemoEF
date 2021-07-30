using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
//using DemoEF_BAL;

using DTO;

namespace DemoEF_UI
{
    class Program
    {
        static void Main(string[] args)
        {

            BALClass obj = new BALClass();
            var output = obj.GetDetailsOfDepartments();
            foreach (var item in output)
            {
                Console.WriteLine(item.Name);

            }

            /*var outputInsert = obj.AddNewDepartment(newDeptDetails);
            if (retval == 1)
            {
                Console.WriteLine("Dept added!!");
            }*/

            //UPDATE

            Console.WriteLine("Enter Group Name");
            string input = Console.ReadLine();
            DepartmentDTO OBJ = new DepartmentDTO { 
            GroupName=input};

            int returnvalue = obj.UpdateDepartment(OBJ);
            if (returnvalue == 1)
            {
                Console.WriteLine("Group Name updated successfully");
                Console.WriteLine("Updated list");
                var out1 = obj.GetDetailsOfDepartments();
                foreach (var item in out1)
                {
                    Console.WriteLine(item.Name);

                }

            }

            else {
                Console.WriteLine("Something went wrong!!");

            }

            //DELETE
            Console.WriteLine("Enter Group Name");
            string input1 = Console.ReadLine();
            DepartmentDTO OBJ1 = new DepartmentDTO
            {
                GroupName = input
            };

            int returnvalue1 = obj.DeleteDepartment(OBJ1);
            if (returnvalue1 == 1)
            {
                Console.WriteLine("Group Name deleted successfully");
                Console.WriteLine("Updated list");
                var out1 = obj.GetDetailsOfDepartments();
                foreach (var item in out1)
                {
                    Console.WriteLine(item.Name);

                }

            }

            else
            {
                Console.WriteLine("Something went wrong!!");

            }



            /*Working of a Linq Query
             * string[] empName={"Pat","Fred","Stella"};
             * var linqQuery=from x in empName
             *                 where x.Contains("at")
             *                 select x;
             * foreach(var item in linqQuery)
             * {
             * Console.Writeline(item);
             * }
             *     /
            */

            /* DAL obj1 = new DAL();
            var rndList= obj1.GetRNDDepartments();
             foreach (var item in rndList)
             {
                 Console.WriteLine(item.Name + " belongs to " + item.GroupName);

             }*/

            //Same upper GetRNDDepartments() by using parameters
            //DAL obj1 = new DAL();
            //string inputDeptSearch=Console.ReadLine();
            //var rndList = obj1.GetRNDDepartments(inputDeptSearch);
            //foreach (var item in rndList)
            //{
            //   Console.WriteLine(item.Name + " belongs to " + item.GroupName);
            //
            //}
        }
    }
}
