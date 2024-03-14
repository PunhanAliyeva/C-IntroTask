#region Task1

int[] nums = { 3, 14, 38, 25, 48, 61, 52, 9 };
Console.WriteLine("Zehmet olmasa yasinizi daxil edin:");
age:
string strAge = Console.ReadLine();
bool IsCheckAge = byte.TryParse(strAge, out byte age);
if (!IsCheckAge)
{
    Console.WriteLine("Duzgun yas daxil edin..");
    goto age;
}
foreach (int num in nums)
{
    if (num == age)
    {
        IsCheckAge=true;
        break;
    }
    else
    {
        IsCheckAge = false;
    }
}
Console.WriteLine(IsCheckAge);
#endregion



#region Task2

//string[] names = { "Punhan", "Aygun", "Eli", "Server", "Aytac", "Sadat" };
//Console.WriteLine("Sagirdin adini daxil edin:");
//string stuName = Console.ReadLine();
//string text = "";
//foreach (var name in names)
//{
//    if(name.ToLower() == stuName.ToLower())
//    {
//        text = name;
//        break;
//    }
//    else
//    {
//        text = "Bu adda telebe yoxdur..";
//    }
   
//}
//Console.WriteLine(text); 
#endregion