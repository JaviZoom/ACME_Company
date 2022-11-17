using ACME_Company_Data;
using System.Security.Cryptography;

public class ACME_Company
{
    //Function that delete all the space characters from a string
    public static string Trim(string str)
    {
        int i;
        string aux ="";
        for (i = 0; i < str.Length; i++)
        {
            if (str[i]!=' ')
            {
                aux = aux + str[i];
            }
        }
        return aux;
    }
    //Function that analyze one string that contains the information of days and working hours from one employee
    public static string[][] Days(string str)
    {
        int i;
        bool exit = false;
        string[][] days = new string[7][];//days of the week
        for (i = 0; i < days.Length; i++)
        {
            days[i] = new string[2];
        }
        while (exit != true)
        {
            switch (str[0])
            {
                //For Monday, just 'M' because it is the only day of the week that starts with that letter
                case 'M':
                    {
                        days[0][0] = Convert.ToString(str[2])+ Convert.ToString(str[3])+ 
                            Convert.ToString(str[4])+ Convert.ToString(str[5])+ Convert.ToString(str[6]);
                        str = str.Remove(0, 8);
                        days[0][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                            Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                        if (str.Length == 5)
                        {
                            str = str.Remove(0, 5);
                        }
                        else
                        {
                            str = str.Remove(0, 6);
                        }
                        break;
                    }
                //For Wednesday, just 'W' because it is the only day of the week that starts with that letter
                case 'W':
                    {
                        days[2][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                        str = str.Remove(0, 8);
                        days[2][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                            Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                        if (str.Length == 5)
                        {
                            str = str.Remove(0, 5);
                        }
                        else
                        {
                            str = str.Remove(0, 6);
                        };
                        break;
                    }
                //For Friday, just 'F' because it is the only day of the week that starts with that letter
                case 'F':
                    {
                        days[4][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                        str = str.Remove(0, 8);
                        days[4][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                            Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                        if (str.Length == 5)
                        {
                            str = str.Remove(0, 5);
                        }
                        else
                        {
                            str = str.Remove(0, 6);
                        }
                        break;
                    }
                //For tuesday and thursday, we also have to analize the second letter in order to know the exactly day of the week
                case 'T':
                    {
                        if (str[1] == 'U')
                        {
                            days[1][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                            str = str.Remove(0, 8);
                            days[1][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                                Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                            if (str.Length == 5)
                            {
                                str = str.Remove(0, 5);
                            }
                            else
                            {
                                str = str.Remove(0, 6);
                            }

                            break;
                        }
                        else if (str[1] == 'H')
                        {
                            days[3][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                            str = str.Remove(0, 8);
                            days[3][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                                Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                            if (str.Length == 5)
                            {
                                str = str.Remove(0, 5);
                            }
                            else
                            {
                                str = str.Remove(0, 6);
                            }
                            break;
                        }
                        else 
                            break;
                        
                    }
                //For saturday and sunday, we also have to analize the second letter in order to know the exactly day of the week
                case 'S':
                    {
                        if (str[1] == 'A')
                        {
                            days[5][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                            str = str.Remove(0, 8);
                            days[5][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                                Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                            if (str.Length == 5)
                            {
                                str = str.Remove(0, 5);
                            }
                            else
                            {
                                str = str.Remove(0, 6);
                            }

                            break;
                        }
                        else if (str[1] == 'U')
                        {
                            days[6][0] = Convert.ToString(str[2]) + Convert.ToString(str[3]) +
                            Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]);
                            str = str.Remove(0, 8);
                            days[6][1] = Convert.ToString(str[0]) + Convert.ToString(str[1]) +
                                Convert.ToString(str[2]) + Convert.ToString(str[3]) + Convert.ToString(str[4]);
                            if (str.Length==5)
                            {
                                str = str.Remove(0, 5);
                            }
                            else
                            {
                                str = str.Remove(0, 6);
                            }
                            break;
                        }
                        else
                            break;
                    }
            }
            if (str == "")
            { 
                exit=true; 
            }
        }
        return days;
    }
    //Function that count the days of the week that the employees have coincided
    public static int Sum(int[] arr)
    {
        int i;
        int aux=0;
        for (i=0;i<arr.Length;i++)
        {
            aux = aux + arr[i];
        }

        return aux;
    }
    //Function that erase all the information of an array
    public static int [] Delete(int[] arr)
    {
        int i;
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
        return arr;
    }

    public static void Main()
    {
        int i, j;//used for iterations
        string line;//this string will save each line of the text document 
        string all;// all string is used to save each line of the employees with their information in order to obtain their names and work information
        char aux;//aux is used to obtain each letter of the name of the employee and then to be saved in the name1 variable
        string name1;//this string will be used to save the name of each employee
        int[] counter=new int [7];//this array will let us know how many times in the week the employees have coincided in the office
        DateTime date1 = new DateTime(0001, 1, 1, 0, 0, 0); //used to compare and asign a null value in one atribute of the employee if equals with this information 
        DateTime dateAux;//used to analize the coincidence between employees
        string[][] days = new string[7][];//jagged array which is used to save the working hours from each employee each day of the week

        //initialization of the jagged array which will contain the period of time of each working day
        for (i=0;i<days.Length;i++)
        {
            days[i] = new string[2];
        }

        //creation of two lists, the first used to save each line read, and the second tha save the information of each employee
        List<string> peopleList = new List<string>();
        List<EmployeeData> employeeData = new List<EmployeeData>();

        try
        {
            
            StreamReader sr = new StreamReader(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Examples.txt"));
            line= sr.ReadLine();
            if (line!=null)
                line = Trim(line);//function Trim used to eliminate every space character
            while (line!=null)
            {
                //clear elements to be used again with new dataset
                peopleList.Clear();
                employeeData.Clear();
                j = 0;
                if (line == "INPUT:")//The program will only work if the first line read is equal to "INPUT:"
                {
                    line = Trim(line);
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    
                    //add each line read to a list 
                    while (line!="INPUT:"&&line!=null) 
                    {
                        line = Trim(line);
                        line = line.ToUpper();
                        peopleList.Add(line);
                        line = sr.ReadLine();
                    }
                    //work with each line individually to obtain employee name and working hours
                    for (i = 0; i < peopleList.Count(); i++) 
                    {
                        all= peopleList[i];
                        Console.WriteLine(all);
                        name1 = "";

                        //obtain the name and assign it to the name1 variable
                        while (all[j] != '=')
                        {
                            aux = all[j];
                            name1 = name1 + aux;
                            all = all.Remove(0, 1);
                        }
                        all = all.Remove(0, 1);//removes the "=" 
                        days = Days(all);//[][] jagged array now contains in and out working hours (Function Days take the remaining of the line)
                        //Now with the jagged array we can easily create the object employee with its own attributes
                        employeeData.Add(new EmployeeData() {Name=name1, Mondayin= Convert.ToDateTime(days[0][0]),Mondayout= Convert.ToDateTime(days[0][1]),
                            Tuesdayin = Convert.ToDateTime(days[1][0]), Tuesdayout = Convert.ToDateTime(days[1][1]),
                            Wednesdayin = Convert.ToDateTime(days[2][0]), Wednesdayout = Convert.ToDateTime(days[2][1]),
                            Thursdayin = Convert.ToDateTime(days[3][0]), Thursdayout = Convert.ToDateTime(days[3][1]),
                            Fridayin = Convert.ToDateTime(days[4][0]), Fridayout = Convert.ToDateTime(days[4][1]),
                            Saturdayin = Convert.ToDateTime(days[5][0]), Saturdayout = Convert.ToDateTime(days[5][1]),
                            Sundayin = Convert.ToDateTime(days[6][0]), Sundayout = Convert.ToDateTime(days[6][1])
                        });
                        
                    }
                    //if the date and hour is equal to 0001/1/1 it means that the employee didn't work that day, so that day is set as a null attribute
                    foreach(EmployeeData employee in employeeData)
                    {
                        if (employee.Mondayin == date1 || employee.Mondayout==date1) 
                        {
                            employee.Mondayin = null;
                            employee.Mondayout = null;
                        }
                        if(employee.Tuesdayin == date1 || employee.Tuesdayout == date1)
                        {
                            employee.Tuesdayin = null;
                            employee.Tuesdayout = null;
                        }
                        if (employee.Wednesdayin == date1 || employee.Wednesdayout == date1)
                        {
                            employee.Wednesdayin = null;
                            employee.Wednesdayout = null;
                        }
                        if (employee.Thursdayin == date1 || employee.Thursdayout == date1)
                        {
                            employee.Thursdayin = null;
                            employee.Thursdayout = null;    
                        }
                        if (employee.Fridayin == date1 || employee.Fridayout == date1)
                        {
                            employee.Fridayin = null;
                            employee.Fridayout = null;
                        }
                        if (employee.Saturdayin == date1 || employee.Saturdayout == date1)
                        {
                            employee.Saturdayin = null;
                            employee.Saturdayout = null;
                        }
                        if (employee.Sundayin == date1 || employee.Sundayout == date1)
                        {
                            employee.Sundayin = null;
                            employee.Sundayout = null;
                        }
                    }
                    Console.WriteLine("\nOUTPUT:");
                    //Here we can find the main logic of the problem
                    //The employees attributes are compared in order to know if they have been in the office at the same time 
                    for (i=0;i<employeeData.Count();i++)
                    {
                        if (employeeData.Count()!=1)//if there is just one employee, there's nothing to compare
                        {
                            for (j = i + 1; j < employeeData.Count(); j++)
                            {

                                Console.Write(employeeData[i].Name + "-" + employeeData[j].Name + ": ");//Write in console the name of the employees that are being compared
                                //Monday comparison 
                                if (employeeData[i].Mondayin != null && employeeData[j].Mondayin!=null)//It is extricty necesary that the employees that are being compared, worked the same day
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Mondayin); dateAux <= employeeData[j].Mondayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        //if the second employee working hour is in between the first employee working hour, that means that they have coincided in the office
                                        if ((dateAux >= employeeData[i].Mondayin) && (dateAux <= employeeData[i].Mondayout))
                                        {
                                            counter[0] = 1;
                                            break;//it is not necessary to continue, that is because we already know that they have coincided in the office
                                        }
                                    }
                                }
                                //Tuesday comparison 
                                if (employeeData[i].Tuesdayin != null && employeeData[j].Tuesdayin != null)
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Tuesdayin); dateAux <= employeeData[j].Tuesdayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Tuesdayin) && (dateAux <= employeeData[i].Tuesdayout))
                                        {
                                            counter[1] = 1;
                                            break;
                                        }
                                    }
                                }
                                //Wednesday comparison 
                                if (employeeData[i].Wednesdayin != null && employeeData[j].Wednesdayin != null)
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Wednesdayin); dateAux <= employeeData[j].Wednesdayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Wednesdayin) && (dateAux <= employeeData[i].Wednesdayout))
                                        {
                                            counter[2] = 1;
                                            break;
                                        }
                                    }
                                }
                                //Thursday comparison 
                                if (employeeData[i].Thursdayin != null && employeeData[j].Thursdayin != null)
                                { 
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Thursdayin); dateAux <= employeeData[j].Thursdayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Thursdayin) && (dateAux <= employeeData[i].Thursdayout))
                                        {
                                            counter[3] = 1;
                                            break;
                                        }
                                    }
                                }
                                //Friday comparison 
                                if (employeeData[i].Fridayin != null && employeeData[j].Fridayin != null)
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Fridayin); dateAux <= employeeData[j].Fridayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Fridayin) && (dateAux <= employeeData[i].Fridayout))
                                        {
                                            counter[4] = 1;
                                            break;
                                        }
                                    }
                                }
                                //Saturday comparison 
                                if (employeeData[i].Saturdayin != null && employeeData[j].Saturdayin != null)
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Saturdayin); dateAux <= employeeData[j].Saturdayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Saturdayin) && (dateAux <= employeeData[i].Saturdayout))
                                        {
                                            counter[5] = 1;
                                            break;
                                        }
                                    }
                                }
                                //Sunday comparison 
                                if (employeeData[i].Sundayin != null && employeeData[j].Sundayin != null)
                                {
                                    for (dateAux = Convert.ToDateTime(employeeData[j].Sundayin); dateAux <= employeeData[j].Sundayout; dateAux = dateAux.AddMinutes(1))
                                    {
                                        if ((dateAux >= employeeData[i].Sundayin) && (dateAux <= employeeData[i].Sundayout))
                                        {
                                            counter[6] = 1;
                                            break;
                                        }
                                    }
                                }
                                Console.WriteLine(Sum(counter));//Function sum to know the the number of days that they have coincided
                                counter = Delete(counter);
                            }
                        }
                    }
                    Console.WriteLine("\n------------------------------------------------------\n");
                }  
            }
            sr.Close();
            Console.ReadKey();
        }
        catch (Exception e) 
        {
            Console.WriteLine(e);   
        }
    }
}   