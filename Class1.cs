using System;
using System.Collections.Generic;
namespace Assignment1
{
    public class Class1
    {
        public List<String> fname = new List<String>();
        public List<String> surname = new List<String>();
        public List<int> age = new List<int>();
        public List<String> Department = new List<String>();
        public List<int> salary = new List<int>();

        //adding all employee info in a single dictionary
        public void addData(Dictionary<int, List<object>> employeeData,List<object> employeeInfo, int index)
        {
            employeeData.Add(index,employeeInfo);
        }
        public void searchAndPrintString(Dictionary<int,List<object>> employeeData,string val)
        {
            foreach(var index in employeeData)
            {
                List<object> valueList = index.Value;
                foreach(var values in valueList)
                {
                    if (values.ToString() == val)
                    {
                        List<object> valueList2 = index.Value;
                        foreach (var data in valueList2)
                        {   Console.Write($"{data} ");
                            
                        }
                        Console.WriteLine();
                    }
                }
            }
        }



    }

    
}