
string[] allowedRoles = { "Administrator", "Manager", "User" };
string userInput; 
bool validEntry = false;

Console.WriteLine("Ingresa tu nombre de rol (Administrator, Manager, o User):");

do
{
    userInput = Console.ReadLine(); 

    if (!string.IsNullOrWhiteSpace(userInput)) 
    {
        string trimmedInput = userInput.Trim();

        
        foreach (string role in allowedRoles)
        {
            if (trimmedInput.Equals(role, StringComparison.OrdinalIgnoreCase))
            {
                validEntry = true; 
                Console.WriteLine($"¡Bienvenido/a, {role}!"); 
                break; 
            }
        }

        if (!validEntry)
        {
            Console.WriteLine("Nombre de rol inválido. Por favor, intenta de nuevo.");
            Console.WriteLine("Los roles permitidos son: Administrator, Manager, User.");
        }
    }
    else 
    {
        Console.WriteLine("Tu entrada no puede estar vacía o contener solo espacios. Por favor, intenta de nuevo.");
    }

} while (!validEntry); 

Console.WriteLine("El programa continúa..."); 