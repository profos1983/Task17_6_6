using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Task17_6_6.Interfaces;

namespace Task17_6_6.Classes
{
    internal class RegularAccount : IAccount
    {
        #region Свойства
        // Баланс учетной записи
        public double Balance { get; set; }
        // Процентная ставка
        public double Interest {  get; set; }
        #endregion

        #region Методы
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            
            double Procent = 0.2;

            if (Balance >= 1000)
            {
                Procent = 0.4;
            }
            Interest -= Balance * Procent;

        }
        #endregion
    }
}
