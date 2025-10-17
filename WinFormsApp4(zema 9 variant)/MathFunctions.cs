using System;

namespace WinFormsApp4_zema_9_variant_
{
    public static class MathFunctions
    {
        // --- обычные методы ---
        public static double Compound(double principal, double rate, int years)
        {
            if (principal < 0) throw new ArgumentException("Сумма не может быть отрицательной.");
            if (years < 0) throw new ArgumentException("Период (лет) не может быть отрицательным.");
            double r = rate / 100.0;
            return Math.Round(principal * Math.Pow(1 + r, years), 2);
        }



        public static double Profit(double revenue, double costs)
        {
            if (revenue < 0) throw new ArgumentException("Доход не может быть отрицательным.");
            if (costs < 0) throw new ArgumentException("Затраты не могут быть отрицательными.");
            return Math.Round(revenue - costs, 2);
        }

        public static (bool Success, double Result, string Error) TryProfit(double revenue, double costs)
        {
            try { return (true, Profit(revenue, costs), ""); }
            catch (Exception ex) { return (false, 0, ex.Message); }
        }


        public static double Annuity(double loan, double rate, int months)
        {
            if (loan <= 0) throw new ArgumentException("Сумма кредита должна быть положительной.");
            if (months <= 0) throw new ArgumentException("Количество месяцев должно быть положительным.");
            double monthlyRate = (rate / 100.0) / 12.0;
            if (Math.Abs(monthlyRate) < 1e-12) return Math.Round(loan / months, 2);
            double denom = 1 - Math.Pow(1 + monthlyRate, -months);
            if (Math.Abs(denom) < 1e-12) throw new InvalidOperationException("Невозможно вычислить аннуитетный платёж (деление на ноль).");
            return Math.Round(loan * (monthlyRate / denom), 2);
        }

        public static double ConvertCurrency(double amount, double rate)
        {
            if (amount < 0) throw new ArgumentException("Сумма не может быть отрицательной.");
            if (rate <= 0) throw new ArgumentException("Курс должен быть положительным.");
            return Math.Round(amount * rate, 2);
        }

        public static double Profitability(double revenue, double costs)
        {
            if (costs == 0) throw new DivideByZeroException("Затраты не могут быть равны нулю.");
            if (revenue < 0) throw new ArgumentException("Доход не может быть отрицательным.");
            if (costs < 0) throw new ArgumentException("Затраты не могут быть отрицательными.");
            return Math.Round(((revenue - costs) / costs) * 100.0, 2);
        }

        // --- Try-методы для безопасной проверки ---
        public static (bool Success, double Result, string Error) TryCompound(double principal, double rate, int years)
        {
            try { return (true, Compound(principal, rate, years), ""); }
            catch (Exception ex) { return (false, 0, ex.Message); }
        }

        public static (bool Success, double Result, string Error) TryAnnuity(double loan, double rate, int months)
        {
            try { return (true, Annuity(loan, rate, months), ""); }
            catch (Exception ex) { return (false, 0, ex.Message); }
        }

        public static (bool Success, double Result, string Error) TryConvertCurrency(double amount, double rate)
        {
            try { return (true, ConvertCurrency(amount, rate), ""); }
            catch (Exception ex) { return (false, 0, ex.Message); }
        }

        public static (bool Success, double Result, string Error) TryProfitability(double revenue, double costs)
        {
            try { return (true, Profitability(revenue, costs), ""); }
            catch (Exception ex) { return (false, 0, ex.Message); }
        }
    }
}
