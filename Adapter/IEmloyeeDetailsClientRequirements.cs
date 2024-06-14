using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IEmloyeeDetailsClientRequirements
    {
        public string GetEmployeeName(int employeeId);
        public string GetEmployeeSurname(int employeeId);
        public string GetEmployeeDetails(int employeeId);
    }
}
