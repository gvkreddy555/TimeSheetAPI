using System;
using System.Collections.Generic;
using System.Linq;
using timesheet.data;
using timesheet.model;

namespace timesheet.business
{
    public class EmployeeService : IDisposable
    {
        public TimesheetDb dbCnxt { get; }
        public EmployeeService(TimesheetDb dbContext)
        {
            this.dbCnxt = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var emps = db.Employees.ToList();
            return emps;
        }

        public void Dispose()
        {
            dbCnxt.Dispose();
        }
    }
}
