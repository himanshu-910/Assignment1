using Assignment1;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Class1 myObject = new Class1();
        myObject.fname.AddRange(new List<string> {
    "Emma", "Liam", "Olivia", "Noah", "Ava", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia",
    "Harper", "Evelyn", "Abigail", "Emily", "Elizabeth", "Sofia", "Avery", "Ella", "Scarlett", "Grace",
    "Chloe", "Victoria", "Riley", "Aria", "Lily", "Aubrey", "Zoey", "Penelope", "Layla", "Nora",
    "Scarlett", "Madison", "Hannah", "Aria", "Addison", "Ellie", "Stella", "Natalie", "Zoe", "Leah",
    "Hazel", "Violet", "Aurora", "Savannah", "Audrey", "Brooklyn", "Bella", "Claire", "Skylar", "Paisley",
    "Everly", "Ariana", "Naomi", "Lillian", "Zoe", "Camila", "Aubree", "Hannah", "Lila", "Ellie",
    "Mila", "Aurora", "Maya", "Harper", "Savannah", "Addison", "Willow", "Ellie", "Nova", "Aubrey",
    "Amelia", "Aria", "Grace", "Riley", "Zoe", "Scarlett", "Emily", "Leah", "Addison", "Hazel",
    "Audrey", "Brooklyn", "Nora", "Bella", "Claire", "Zoey", "Skye", "Lily", "Eleanor", "Stella",
    "Ellie", "Lily", "Aurora", "Ivy", "Violet", "Paisley", "Ariana", "Lily", "Chloe", "Scarlett"
}
);
        myObject.surname.AddRange(new List<string> {
    "Smith", "Johnson", "Williams", "Jones", "Brown", "Kumar", "Davis", "Miller", "Patel", "Taylor",
    "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
    "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King",
    "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter",
    "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Sharma", "Campbell", "Parker", "Evans", "Edwards",
    "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy",
    "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray",
    "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes",
    "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores",
    "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz",
    "Hayes", "Sinha", "Rao", "Verma", "Singh", "Malhotra", "Chowdhury", "Gupta", "Pandey", "Shah"
}
);
        myObject.age.AddRange(new List<int> {
    21, 22, 25, 28, 30, 32, 35, 38, 40, 42,
    45, 48, 50, 52, 55, 58, 60, 25, 30, 35,
    40, 45, 50, 55, 28, 32, 38, 42, 48, 52,
    21, 30, 35, 45, 55, 60, 25, 38, 42, 52,
    28, 32, 50, 58, 22, 30, 35, 45, 55, 60,
    25, 38, 42, 52, 28, 32, 50, 58, 21, 30,
    35, 45, 55, 60, 25, 38, 42, 52, 28, 32,
    50, 58, 21, 30, 35, 45, 55, 60, 25, 38,
    42, 52, 22, 32, 50, 58, 21, 30, 35, 45,
    55, 60, 25, 26, 27, 29, 31, 22, 38, 40
});
        myObject.Department.AddRange(new List<string> {
    "IT", "HR", "Marketing", "Finance", "IT", "Sales", "Operations", "IT", "IT", "Engineering",
    "Customer Support", "IT", "Research and Development", "IT", "HR", "IT", "Marketing", "Finance",
    "Sales", "Operations", "IT", "Engineering", "Customer Support", "IT", "Research and Development",
    "IT", "HR", "IT", "Marketing", "Finance", "Sales", "Operations", "IT", "Engineering", "Customer Support",
    "IT", "Research and Development", "IT", "HR", "IT", "Marketing", "Finance", "Sales", "Operations",
    "IT", "Engineering", "Customer Support", "IT", "Research and Development", "IT", "HR", "IT", "Marketing",
    "Finance", "Sales", "Operations", "IT", "Engineering", "Customer Support", "IT", "Research and Development",
    "IT", "HR", "IT", "Marketing", "Finance", "Sales", "Operations", "IT", "Engineering", "Customer Support",
    "IT", "Research and Development", "IT", "HR", "IT", "Marketing", "Finance", "Sales", "Operations",
    "IT", "Engineering", "Customer Support", "IT", "Research and Development", "IT", "HR", "IT", "Marketing",
    "Finance", "Sales", "Operations", "IT", "Engineering", "Customer Support", "HR", "IT", "Marketing", "Finance", "Sales"
});
        myObject.salary.AddRange(new List<int> {
    25000, 35000, 50000, 60000, 75000, 80000, 100000, 120000, 150000, 180000,
    20000, 40000, 55000, 70000, 85000, 90000, 110000, 130000, 160000, 200000,
    30000, 45000, 65000, 85000, 95000, 100000, 125000, 140000, 170000, 190000,
    22000, 32000, 48000, 65000, 75000, 85000, 105000, 125000, 155000, 180000,
    22000, 35000, 52000, 65000, 78000, 88000, 100000, 125000, 150000, 190000,
    21000, 36000, 50000, 62000, 74000, 85000, 100000, 120000, 145000, 185000,
    23000, 38000, 53000, 68000, 80000, 90000, 105000, 130000, 160000, 195000,
    24000, 40000, 55000, 70000, 82000, 93000, 110000, 135000, 170000, 200000,
    26000, 42000, 57000, 70000, 84000, 95000, 115000, 140000, 175000, 180000,
    28000, 44000, 59000, 74000, 86000, 97000, 120000, 145000, 190000, 200000
}
);
        Dictionary<int, List<object>> employeeData = new Dictionary<int, List<object>>();
        for (int i = 0; i < 100; i++)
        {
            List<object> employeeInfo = new List<object>
            {
                 myObject.fname[i], myObject.surname[i],myObject.age[i],myObject.Department[i],myObject.salary[i]
            };
            //adding key value
            myObject.addData(employeeData, employeeInfo,i+1);
            //Console.WriteLine(employeeInfo);
        }

        foreach (var data in employeeData)
        {
            int key = data.Key;
            List<object> values = data.Value;

            Console.Write($"Key: {key} ");
            Console.Write("Value: ");
            int i = 0;
            foreach (var value in values)
            {
                i++;
                Console.Write($"{value} ");
                if (i <= 4)
                {
                    Console.Write(',');
                }
                else
                {
                    i=0;
                }
            }

            Console.WriteLine();
        }


        //Searching and printing name department surname
        string info = "22";
        myObject.searchAndPrintString(employeeData,info);
    }
}