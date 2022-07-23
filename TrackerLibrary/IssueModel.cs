using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class IssueModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public EmployeeModel Employee { get; set; }
    }
}
