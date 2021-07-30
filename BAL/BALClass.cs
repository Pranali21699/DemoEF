using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF;
using DTO;

namespace BAL
{
    public class BALClass
    {
        DAL obj;
        public BALClass()
        {
            obj = new DAL();
        }

        public List<DepartmentDTO>GetDetailsOfDepartments()
        {
            var result = obj.GetDepartments();
            return result ;
        }

        public int AddNewDepartment(DepartmentDTO newDeptDetails)
        {
            int retval = obj.AddNewDepartment(newDeptDetails);
            return retval;
        }

        public int UpdateDepartment(DepartmentDTO newDeptDetails)
        {
            int retval = obj.UpdateDepartment(newDeptDetails);
            return retval;
        }

        public int DeleteDepartment(DepartmentDTO newDeptDetails)
        {
            int retval = obj.DeleteDepartment(newDeptDetails);
            return retval;
        }

    }
}
