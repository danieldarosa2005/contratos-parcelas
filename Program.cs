using System;
using System.Globalization;

System.Console.WriteLine("Enter contract data");
System.Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

System.Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());

System.Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine());

System.Console.Write("Enter number of installments: ");
int insta = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, insta);

System.Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments) {
    System.Console.WriteLine(installment);
}