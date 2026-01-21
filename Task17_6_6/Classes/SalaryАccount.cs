using System;
using System.Collections.Generic;
using System.Text;
using Task17_6_6.Interfaces;

namespace Task17_6_6.Classes
{
    internal class SalaryАccount : IAccount
    {
        #region Свойства
        public double Balance { get; set; }
        // Процентная ставка
        public double Interest { get; set; }
        #endregion

        #region Методы
        public void CalculateInterest()
        {
            this.Interest = Balance * 0.5;
        }
        #endregion
    }
}
