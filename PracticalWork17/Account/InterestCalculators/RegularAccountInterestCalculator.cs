namespace PracticalWork17.Account.InterestCalculators;

// Калькулятор для обычных аккаунтов
public class RegularAccountInterestCalculator : IInterestCalculator
{
    // Реализация метода расчета процентной ставки для обычного аккаунта
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.4; // Базовая ставка

        switch (account.Balance)
        {
            case < 1000:
                account.Interest -= account.Balance * 0.2; // Уменьшение ставки для баланса < 1000
                break;
            case >= 1000:
                account.Interest -= account.Balance * 0.4; // Уменьшение ставки для баланса >= 1000
                break;
        }
    }
}
