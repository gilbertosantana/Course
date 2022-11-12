﻿using System.Globalization;
using InterfaceExercice.Entities;
using InterfaceExercice.Services;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int numberContract = int.Parse(Console.ReadLine()!);
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine()!);

Contract myContract = new Contract(numberContract, contractDate, contractValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, months);
Console.WriteLine("Installments:");
foreach (Installment installment in myContract.Installments)
{
    Console.WriteLine(installment.ToString());
}