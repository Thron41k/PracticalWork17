using PracticalWork17.Account.InterestCalculators;

namespace PracticalWork17.Account;

// Класс учетной записи
public class Account(IInterestCalculator interestCalculator)
{
    // Тип учетной записи (например, "Обычный" или "Зарплатный")
    public string? Type { get; set; }

    // Баланс учетной записи
    public double Balance { get; set; }

    // Процентная ставка учетной записи
    public double Interest { get; set; }

    // Метод для расчета процентной ставки
    public void CalculateInterest()
    {
        interestCalculator.CalculateInterest(this);
    }
}