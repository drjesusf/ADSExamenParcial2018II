using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public class PersonUnder50Rule: ISalaryRule
    {
        private int salaryByDayUnder50 = 100;

        public int CalculateSalary(int workedDays)
        {
            return salaryByDayUnder50*workedDays;
        }

        public bool IsMatch(WorkPerson person)
        {
            return person.Age <= 50;
        }
    }
}
