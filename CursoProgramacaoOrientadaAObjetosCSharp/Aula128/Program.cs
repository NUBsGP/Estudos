﻿using System;
using System.Globalization;
using ExercicioResolvido01.Entities;
using ExercicioResolvido01.Entities.Enums;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departamentName = Console.ReadLine();
            Departament departament = new Departament(departamentName);
            Console.Write("\nEnter worker data:\n" +
                              "Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = WorkerLevel.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, departament);

            Console.Write("\nHow many contracts to this worker? ");
            int workerContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < workerContracts; i++)
            {
                Console.Write($"\nEnter #{i + 1} contract data:\n" +
                               "Date (DD/MM/YYYY): ");
                DateTime contractData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int contractHour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(contractData, contractValuePerHour, contractHour);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            DateTime incomeData = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
            double incomeValue = worker.Income(int.Parse(incomeData.Year.ToString()), int.Parse(incomeData.Month.ToString()));
            Console.WriteLine($"\nName: {worker.Name}\n" +
                              $"Departament: {worker.Departament.Name}\n" +
                              $"Income for {incomeData.ToString("MM/yyyy", CultureInfo.InvariantCulture)}: {incomeValue.ToString("f2", CultureInfo.InvariantCulture)}");

            
        }
    }
}