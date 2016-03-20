using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************/
/* Author:LiChao
/* Date:2016/02/29
/* Description:Design Pattern Begin
/* Target:对于不同的员工发放工资问题，这是一个多态性质的问题，因为不同的员工工资计算方法是不同的
/*        写一个抽象类，其中包含一个抽象方法，每一种员工的种类通过继承来重写获取工资的方法，
/*        这样，如果有新的员工种类加进来，只需要新加一个项目，在其中加入新的员工类，重写适合
/*        于该种类员工的获取工资方法。这样，不需要编译就可以完成新的需求。                                           
/**************************************************************/

namespace DesignPattern
{

    public enum EmployeeType
    {
        Engineer,
        Sales,
        Manager
    }

    abstract class Employee
    {
        public abstract int GetSalary();
    }

    class Sales : Employee
    {
        public override int GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
