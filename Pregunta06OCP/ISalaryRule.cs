using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public interface ISalaryRule
    {
        bool IsMatch(WorkPerson person);
        int CalculateSalary(WorkPerson person);
    }
}
