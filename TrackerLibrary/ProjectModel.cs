using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class ProjectModel
    {
        public  String name { get; set; }
        public String description { get; set; }
        public List<EmployeeModel> employees { get; set; }
        
    }
}