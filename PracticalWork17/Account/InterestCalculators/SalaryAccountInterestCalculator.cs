namespace PracticalWork17.Account.InterestCalculators;

// Калькулятор для зарплатных аккаунтов
public class SalaryAccountInterestCalculator : IInterestCalculator
{
    // Реализация метода расчета процентной ставки для зарплатного аккаунта
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.5; // Фиксированная ставка
    }
}
