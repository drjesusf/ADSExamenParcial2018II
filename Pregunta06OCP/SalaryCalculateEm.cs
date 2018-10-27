using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pregunta06OCP
{
    public class SalaryCalculateEm : ISalaryCalculator
    {
        private List<ISalaryRule> salaryRules;

        public SalaryCalculateEm()
        {
            salaryRules = new List<ISalaryRule>();
            salaryRules.Add(new PersonOver50Rule());
            salaryRules.Add(new PersonUnder50Rule());
        }
        

        public int CalculateSalary(WorkPerson person, int workedDays)
        {

            var salary = 0;
            if (person == null) return 0;

            salary = salaryRules.First(x => x.IsMatch(person)).CalculateSalary(workedDays);

            return salary;
        }
    }
}
