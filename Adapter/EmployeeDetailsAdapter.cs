using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EmployeeDetailsAdapter : IEmloyeeDetailsClientRequirements
    {
        private readonly LegacyGetEmployeeDetails _legacyGetEmployeeDetails;
        public EmployeeDetailsAdapter(LegacyGetEmployeeDetails legacyGetEmployeeDetails)
        {
            _legacyGetEmployeeDetails = legacyGetEmployeeDetails;
        }
        public string GetEmployeeDetails(int employeeId)
        { 
            string[] details = _legacyGetEmployeeDetails.GetEmpDet(employeeId)
                .Split(Environment.NewLine);
            details[0] = "ID: " + details[0];
            details[1] = "Name: " + details[1];
            details[2] = "Surname: " + details[2];
            details[3] = "Additional data: " + details[3];

            return string.Join(Environment.NewLine, details);
        }

        public string GetEmployeeName(int employeeId)
        {
            string[] details = _legacyGetEmployeeDetails.GetEmpDet(employeeId)
                .Split(Environment.NewLine);
            return details[1];
        }

        public string GetEmployeeSurname(int employeeId)
        {
            string[] details = _legacyGetEmployeeDetails.GetEmpDet(employeeId)
                .Split(Environment.NewLine);
            return details[2];
        }
    }
}
