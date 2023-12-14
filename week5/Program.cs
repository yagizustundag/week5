// AND (&&) OR (||) logical operators

//AND
// true && true => true
// true && false => false 
// false && false => false 

string username, password; //admin and admin1234

Console.WriteLine("Enter the username:");
username = Console.ReadLine();

Console.WriteLine("Enter the password:");
password = Console.ReadLine();

//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome!");
//}
//else
//{
//    Console.WriteLine("Invalid user credentials.");
//}

//OR 
//true || true => true
//false || true => true
//true || false => true
//false || false => false

if (username != "admin" || password != "admin1234")
{
    Console.WriteLine("Invalid user credentials.");
}
else
{
    Console.WriteLine("Welcome!");
}
