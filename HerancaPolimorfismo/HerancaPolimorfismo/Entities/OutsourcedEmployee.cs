﻿using System;


namespace HerancaPolimorfismo.Entities
{
     class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee (string name, int hours, double valuePerHour, double additionalCharge)
            :base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * AdditionalCharge;
        }
    }
}
