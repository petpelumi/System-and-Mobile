// See https://aka.ms/new-console-template for more information
Console.WriteLine("A Sales' man commission based on 500 naira benchmark");
Console.WriteLine("Enter your amount");
double amount = double.Parse(Console.ReadLine());
double percentage = 0.05;
double commission = percentage * amount;
string value;
if (amount >= 500) { value = "your commission is " + commission; }
else { value = "you dont have any commision bro";}


Console.WriteLine(value);
