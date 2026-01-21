using System;
using System.Collections.Generic;
using System.Text;

namespace Task17_6_6.Interfaces
{
    internal interface IAccount
    {
        double Balance { get; set; }
        double Interest { get; set; }
        // Общий метод для аккаунтов, который должен рассчитывать процентную ставку
        void CalculateInterest();
    }
}
