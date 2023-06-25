using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    /*Task 6: 
Create an interface called IEmployee that has methods called GetName(),
    GetSalary(), and GetJobTitle(). Create two classes, FullTimeEmployee and 
    PartTimeEmployee, that implement the IEmployee interface. The FullTimeEmployee 
    class should override the GetName(), GetSalary(), and GetJobTitle() methods to
    return the full-time employee's name, salary, and job title. The PartTimeEmployee
    class should override the GetName(), GetSalary(), and GetJobTitle() methods to 
    return the part-time employee's name, salary, and job title.
    */
    internal interface IEmployee
    {
        string Name { get; set; }
        public int Salary { get; set; }
         
        string JobTitle { get; set; }

        

    }
    class FullTimeEmployee: IEmployee
    {
        public string Name { get; set; }

       public int Salary {  get;  set; }
        public string JobTitle { get; set; }

    }

    class PartTimeEmployee: IEmployee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }
    }
    
}
