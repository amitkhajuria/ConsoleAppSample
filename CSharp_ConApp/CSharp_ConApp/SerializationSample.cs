using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_ConApp
{
    public class SerializationSample
    {
        static void MainSer(string[] args)
        {
            Employee1 objEmp = new Employee1
            {
                name = "sampleName",
                phone = "9876543210",
                dob = DateTime.Now,
                department = "TestDept",
                salary = 50000,
                additionalInfo = "We don't want it to serialize"
            };

          //Serialize
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new System.IO.FileStream("employee.binary", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None);
            var n = "";
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, objEmp);
                    n = "file serialized";
                }
            }
            catch
            {
                n = "An error has occured";
            }

            //Deserialization
            Employee1 objEmpNew = new Employee1();
            
            BinaryFormatter bfd = new BinaryFormatter();
            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            var a = "";
            try
            {
                using (fsin)
                {
                    objEmpNew = (Employee1)bfd.Deserialize(fsin);
                    a = "Object Deserialized";

                    a+="-;"+ objEmpNew.name;
                    a += "-;" + objEmpNew.phone;
                    a += "-;" + objEmpNew.dob;
                    a += "-;" + objEmpNew.department;
                    a += "-;" + objEmpNew.salary.ToString();
                }

            }
            catch
            {
                a = "An error has occured";
            }

        }//main
      }//class
    }//namesapce


//For xml serialization use XmlSerializer instead of BinaryFormatter.
//1.	XmlSerializer xs = new XmlSerializer(typeof(Employee));
//Change the filename from "employee.binary" to "employee.xml". 
//and use[Xmlgnore] instead of[NonSerialized] in Employee class. The rest will be the same.



  [Serializable]
    public class Employee1
    {
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Phone;
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        private DateTime DoB;
        public DateTime dob
        {
            get { return DoB; }
            set { DoB = value; }
        }

        private string Department;
        public string department
        {
            get { return Department; }
            set { Department = value; }
        }

        private int Salary;
        public int salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        [NonSerialized]
        public string additionalInfo;
    }


