using System;
using System.Collections.Generic;
using System.Linq;
using timesheet.data;
using timesheet.model;

namespace timesheet.business
{
    public class TaskService : IDisposable
    {
        public TimesheetDb db { get; }

        public TaskService(TimesheetDb dbContext)
        {
            this.db = dbContext;
        }

        public IEnumerable<Task> GetTasks()
        {
            var tasks = db.Tasks.ToList();
            return tasks;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
