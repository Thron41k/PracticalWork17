namespace PracticalWork17.Account.InterestCalculators;

// Интерфейс для расчета процентной ставки
public interface IInterestCalculator
{
    // Метод для расчета процентной ставки
    void CalculateInterest(Account account);
}