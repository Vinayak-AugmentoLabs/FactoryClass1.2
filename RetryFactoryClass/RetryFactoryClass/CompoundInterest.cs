﻿/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'CompoundIneterest' class
/// </summary>
namespace RetryFactoryClass
{
    class CompoundInterest : IfactoryInterest
    {
        double amount;
        int years;
        float roi;
        int annualCompound;
        public CompoundInterest(double amount, int years, float roi, int annualCompound)
            {
            this.amount = amount;
            this.years = years;
            this.roi = roi;
            this.annualCompound = annualCompound;
        }
        public double Interest()
        {
            double result = 0;
            result = amount * Math.Pow((1 + (roi / annualCompound)), (annualCompound * years));

            return result;
        }
    }
}