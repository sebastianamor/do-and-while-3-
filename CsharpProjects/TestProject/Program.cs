string[] uSers =  {"Administrator" "Manager" "User"}
bool validEntry = false;
Console.WriteLine("Enter your role name:");
do
{
    uSers = Console.ReadLine();
    if (uSers != null)
    {
        if (uSers.Length >= 1)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid , please try again.");
        }
    }
} while (validEntry == false);