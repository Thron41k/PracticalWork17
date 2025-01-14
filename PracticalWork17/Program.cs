using PracticalWork17.Account;
using PracticalWork17.Account.InterestCalculators;

// Создание обычного аккаунта
var regularAccount = new Account(new RegularAccountInterestCalculator())
{
    Type = "Обычный",
    Balance = 1500
};
regularAccount.CalculateInterest();
Console.WriteLine($"Тип: {regularAccount.Type}, Баланс: {regularAccount.Balance}, Процент: {regularAccount.Interest}");

// Создание зарплатного аккаунта
var salaryAccount = new Account(new SalaryAccountInterestCalculator())
{
    Type = "Зарплатный",
    Balance = 2000
};
salaryAccount.CalculateInterest();
Console.WriteLine($"Тип: {salaryAccount.Type}, Баланс: {salaryAccount.Balance}, Процент: {salaryAccount.Interest}");