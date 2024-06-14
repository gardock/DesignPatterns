namespace Adapter
{
    public class LegacyGetEmployeeDetails
    {
        public string GetEmpDet(int empId)
        {
            return $"{empId}" + Environment.NewLine +
                "Jan" + Environment.NewLine +
                "Kowalski" + Environment.NewLine +
                "Dyrektor" + Environment.NewLine +
                "Ulica 12";
        }
    }
}
