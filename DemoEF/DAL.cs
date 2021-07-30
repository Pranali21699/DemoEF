using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF;
using DTO;

namespace DemoEF
{
    public class DAL
    {
        public List<DepartmentDTO> GetDepartments()
        {
            try
            {
                List<DepartmentDTO> lstDepartments = new List<DepartmentDTO>();
                AdventureWorks2012Entities advContext = new AdventureWorks2012Entities();
                var deptDALListObjects = advContext.Departments.ToList();
                foreach (var dept in deptDALListObjects)
                {
                    lstDepartments.Add(
                        new DepartmentDTO
                        {
                            DepartmentID = dept.DepartmentID,
                            Name = dept.Name,
                            GroupName = dept.GroupName,
                            ModifiedDate = dept.ModifiedDate
                        });
                }
                return lstDepartments;

            }

            catch (Exception ex)
            {
                throw ex;

            }

        }

        public int AddNewDepartment(DepartmentDTO newDeptObj)
        {
            int ret = 0;
            //throw new NotImplementedException();
            try
            {
                using (var context = new AdventureWorks2012Entities())
                {
                    Department depDalobj = new Department();

                    depDalobj.Name = newDeptObj.Name;
                    depDalobj.GroupName = newDeptObj.GroupName;
                    depDalobj.ModifiedDate = newDeptObj.ModifiedDate;
                    context.Departments.Add(depDalobj);
                    ret = context.SaveChanges();
                    return ret;


                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }


        /* using(var db=new datacontext())
         {
         }
        */
        public List<Department> GetRNDDepartments()
        {
            try
            {
                //LINQ:
                AdventureWorks2012Entities advContext = new AdventureWorks2012Entities();
                var rndDeptList = advContext.Departments.Where(x => x.GroupName == "Research and Development").ToList();
                return rndDeptList;

                /*
                 var query=from dept in advContext.Departments
                            where dept.GroupName=="Research and Development"
                            select dept;*/

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<Department> DeleteDepartment(DepartmentDTO newDeptObj)
        {
            int ret = 0;
            try
            {
                using (var context = new AdventureWorks2012Entities())
                {
                    Department depDalobj = context.Departments.Find(newDeptObj.GroupName);


                    depDalobj.GroupName = newDeptObj.GroupName;

                    context.Departments.Add(depDalobj);
                    ret = context.SaveChanges();
                    return ret;


                }



            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public List<Department> UpdateDepartment(DepartmentDTO newDeptObj)
        {
            int ret = 0;
            try
            {
                using (var context = new AdventureWorks2012Entities())
                {
                    Department depDalobj = context.Departments.Find(newDeptObj.GroupName);

                    context.Departments.Attach(depDalobj);

                    depDalobj.GroupName = newDeptObj.GroupName;

                    //context.Departments.Add(depDalobj);
                    ret = context.SaveChanges();
                    return ret;


                }



            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}