// (c) Khaled A Alwan .
// All other rights reserved.
using System;

namespace germsVage
{
    /// <summary>
    /// connect the age and the Germs in this class
    /// also, 
    /// set the string values for Age in Ages
    /// and the Ger in Gers
    /// </summary>
    public class gVaitem
    {
        /// <summary>
        /// The Age
        /// </summary>
        public double Age { get; set; }
        /// <summary>
        /// The number of Germs in trillions that may caused the above age to be that short.
        /// </summary>
        public double Ger { get; set; }
        /// <summary>
        /// string for the Age
        /// </summary>
        public string Ages { get; set; }
        /// <summary>
        /// string for the Ger
        /// </summary>
        public string Gers { get; set; }
        public gVaitem()
        {

        }
        /// <summary>
        /// Fill in missing data from the ger input
        /// <c>Age = 72.0/Math.Log10(ger)</c>
        /// <c>Ger = geer;</c>
        /// <c>Call SetStr()</c>
        /// </summary>
        /// <param name="ger">The running list value as input in trillions</param>
        public void setAge(double ger)
        {
            if( ger < 1.0)
            {
                throw new InvalidOperationException("SetAge:ger: must not equal 0 or 1");
            }

            double logger = Math.Log10(ger);

            if (logger !=  (double)0)
            {
                Age = 72.0 / logger;
                Ger = ger;
                SetStr();
            }
 
        }
        /// <summary>
        /// Fill in the String values for Ages and Gers from Age and Ger
        /// </summary>
        private void SetStr()
        {
            Ages = string.Format("{0:F0}", Age);
            Gers = string.Format("{0:F2}", Ger);
        }
        /// <summary>
        /// Fill in Age and Ger 
        /// from the calculation 
        /// in this method.
        /// <c>Age = age;</c>
        /// <c>Ger = Math.pow(10,log);//where log is below</c>
        /// <c>log = 72/age;</c>
        /// </summary>
        /// <param name="age">age for which the Ger is to be calculated.</param>
        public void setGer(double age)
        {
            this.Age = age;
            double log = 72.0 / age;
            this.Ger = Math.Pow(10, log);
            SetStr();

        }
    }
}