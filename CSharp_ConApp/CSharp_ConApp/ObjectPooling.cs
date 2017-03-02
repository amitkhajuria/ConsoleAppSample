using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{

    class EmployeeOP
    {
        public static int Counter = 0;
        public EmployeeOP()
        {
            ++Counter;
        }
        public int MyProperty { get; set; }
    }

    class Factory
    {
        private static int _PoolMaxSize = 2;
        private static readonly Queue objPool = new Queue(_PoolMaxSize);

        public EmployeeOP GetEmployee()
        {
            EmployeeOP oEmployee;

            // check from the collection pool. If exists return object else create new
            if (EmployeeOP.Counter >= _PoolMaxSize && objPool.Count > 0)
            {
                // Retrieve from pool
                oEmployee = RetrieveFromPool();
            }
            else
            {
                oEmployee = GetNewEmployee();
            }
            return oEmployee;
        }
        private EmployeeOP GetNewEmployee()
        {
            // Creates a new employee
            EmployeeOP oEmp = new EmployeeOP();
            objPool.Enqueue(oEmp);
            return oEmp;
        }
        protected EmployeeOP RetrieveFromPool()
        {
            EmployeeOP oEmp;

            // if there is any objects in my collection
            if (objPool.Count > 0)
            {
                oEmp = (EmployeeOP)objPool.Dequeue();
                EmployeeOP.Counter--;
            }
            else
            {
                // return a new object
                oEmp = new EmployeeOP();
            }
            return oEmp;
        }

    }

    class ObjectPooling
    {
        static void MainOP(string[] args)
        {
            Factory fa = new Factory();

            EmployeeOP myEmp = fa.GetEmployee();
            Console.WriteLine("First object");

            EmployeeOP myEmp1 = fa.GetEmployee();
            Console.WriteLine("Second object");

            EmployeeOP myEmp3 = fa.GetEmployee();
            Console.WriteLine("Existing object");

            Console.ReadKey();
        }
    }

}
