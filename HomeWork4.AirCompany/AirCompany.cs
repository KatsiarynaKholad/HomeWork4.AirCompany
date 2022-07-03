using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.AirCompany
{
    public class AirCompany
    {
        public string Name { get;  set; }
        public double Capacity { get;  set; } 
        public double Carrying { get;  set; }     
        public double Range { get;  set; }      

        public List<AirCompany> planesList = new List<AirCompany>();

        public void PrintInfo()
        {
            foreach (var item in planesList)
            {
                Console.WriteLine($"Name - {item.Name} \t|| capacity - {item.Capacity} \t|| carrying - {item.Carrying} \t|| range - {item.Range}");

            }
        }

        public double CountTotalCapacity()
        {
            double totalCapacity = 0;
            foreach (var item in planesList)
            {
                var result = item.Capacity;
                totalCapacity = result + totalCapacity;
            }
            return totalCapacity;
        }

        public double CountTotalCarrying()
        {
            double totalCarrying = 0;
            foreach (var item in planesList)
            {
                var result = item.Carrying;
                totalCarrying = result + totalCarrying;
            }
            return totalCarrying;
        }

        public void PrintSortByRange()
        {
            planesList.Sort(delegate (AirCompany x, AirCompany y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return -1;
                else if (y == null) return 1;
                else
                    return x.Range.CompareTo(y.Range);
            });

            PrintInfo();
        }

        public void PrintSortByCapacity()
        {
            planesList.Sort(delegate (AirCompany x, AirCompany y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return -1;
                else if (y == null) return 1;
                else
                    return x.Capacity.CompareTo(y.Capacity);
            });

            PrintInfo();
        }

        public void PrintSortByCarrying()
        {
            planesList.Sort(delegate (AirCompany x, AirCompany y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return -1;
                else if (y == null) return 1;
                else
                    return x.Carrying.CompareTo(y.Carrying);
            });

            PrintInfo();
        }

        public void SampleSort(double key)
        {
            Sample(planesList, key);
        }

        private void Sample(List<AirCompany> planes, double key)
        {
            var newDict = new Dictionary<double, List<AirCompany>>();
            var isContainKey = newDict.ContainsKey(key);

            foreach (var item in planes)
            {
                if (item.Range == key)
                {
                    Console.WriteLine($"Name - {item.Name} \t|| capacity - {item.Capacity} \t|| carrying - {item.Carrying} \t|| range - {item.Range}");
                }
            }
        }

        public void SortByTheGivenRange(double userValue)
        {
            foreach (var item in planesList)
            {
                if (userValue >= item.Range)
                {
                    Console.WriteLine($"Name - {item.Name} \t|| capacity - {item.Capacity} \t|| carrying - {item.Carrying} \t|| range - {item.Range}");
                }
            }
        }
    }
}