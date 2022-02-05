using System;
using System.Collections.Generic;
using Lannister_Qwiktrippin.prompts;
using Lannister_Qwiktrippin.jobs;
using Lannister_Qwiktrippin.repositories;

namespace Lannister_Qwiktrippin
{
    public enum JobTitle
    {
        None,
        Associate,
        AssistantManager,
        StoreManager,
        DistrictManager
    }

    public class Employee
    {
        public static void CreateNewEmployee()
        {
            int storeInput = EnterStoreNumber.Prompt();
            string nameInput = EnterEmployeeName.Prompt();
            Console.WriteLine(@"
Select job title
1. Associate
2. Assistant Manager
3. Store Manager
");
            int selection = Menu.MenuSelection(3);
            Employee? emp = null; //storing the employee 
            JobTitle job = JobTitle.None;      
            switch (selection)
            {
                case 1:
                    job = JobTitle.Associate;
                    emp = new Associate(nameInput, job, storeInput);
                    break;
                case 2:
                    job = JobTitle.AssistantManager;
                    emp = new AssistantManager(nameInput, job, storeInput);
                    break ;
                case 3:
                    job = JobTitle.StoreManager;
                    emp = new StoreManager(nameInput, job, storeInput);
                    break;
                default: break;

            }
            if (emp != null)
            EmployeeRepository.SaveNewEmployee(emp);
            Console.WriteLine($@"
Created {job} named {nameInput} at store #{storeInput}");

            Menu.MainMenuLoop();
        }



        public string Name { get; private set; }
        public JobTitle Position { get; private set; }

        public Employee(string _name, JobTitle _position)
        {
            Name = _name;
            Position = _position;
        }
    }
}
