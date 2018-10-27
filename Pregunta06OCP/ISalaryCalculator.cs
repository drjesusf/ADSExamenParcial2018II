using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public interface ISalaryCalculator
    {
        int CalculateSalary(WorkPerson person, int workedDays);
    }
}
