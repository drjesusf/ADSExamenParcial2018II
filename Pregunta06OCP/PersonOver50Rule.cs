﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public class PersonOver50Rule : ISalaryRule
    {
        private int salaryByDayOver50 = 120;
        public int CalculateSalary(int workedDays)
        {
            return workedDays * salaryByDayOver50;
        }

        public bool IsMatch(WorkPerson person)
        {
            return person.Age>50;
        }
    }
}
