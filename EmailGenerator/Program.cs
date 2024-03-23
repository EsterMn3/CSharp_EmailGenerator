// Define a multidimensional array to store corporate employee names
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

// Define a multidimensional array to store external employee names
string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

// Define the domain for external employees' email addresses
string externalDomain = "hayworth.com";

// Iterate over the corporate array to display email addresses
for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
    //i represents the index of the row in the corporate array, while 0 represents the index of the first column in that row.
}

// Iterate over the external array to display email addresses with the external domain
for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

// Define a method to display email addresses
void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
    // Concatenate the first two characters of the first name with the last name to form the email username
    string email = first.Substring(0, 2) + last;
    // Convert the email username to lowercase
    email = email.ToLower();
    // Display the email address using the email username and the specified domain
    Console.WriteLine($"{email}@{domain}");
}
