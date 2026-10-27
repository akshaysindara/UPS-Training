
using System;

class PasswordChecker
{
    static void Main()
    {
        string password;
        bool strong = false;

        do
        {
            Console.Write("\nEnter a password: ");
            password = Console.ReadLine() ?? "";

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            bool hasSpace = false;

            
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                    hasUpper = true;
                else if (char.IsLower(ch))
                    hasLower = true;
                else if (char.IsDigit(ch))
                    hasDigit = true;
                else if (char.IsWhiteSpace(ch))
                    hasSpace = true;
                else
                    hasSpecial = true;
            }

            bool hasLength = password.Length >= 8;
            bool noSpaces = !hasSpace;

            
            Console.WriteLine("\n--- Password Rules ---");
            Console.WriteLine($"8+ characters: {(hasLength ? "Passed" : "Failed")}");
            Console.WriteLine($"Uppercase letter: {(hasUpper ? "Passed" : "Failed")}");
            Console.WriteLine($"Lowercase letter: {(hasLower ? "Passed" : "Failed")}");
            Console.WriteLine($"Digit: {(hasDigit ? "Passed" : "Failed")}");
            Console.WriteLine($"Special character: {(hasSpecial ? "Passed" : "Failed")}");
            Console.WriteLine($"No spaces: {(noSpaces ? "Passed" : "Failed")}");

            int score = 0;

            if (hasLength) score++;
            if (hasUpper) score++;
            if (hasLower) score++;
            if (hasDigit) score++;
            if (hasSpecial) score++;
            if (noSpaces) score++;

            string rating;

            if (score <= 2)
                rating = "Weak";
            else if (score <= 4)
                rating = "Medium";
            else
                rating = "Strong";

            Console.WriteLine($"Password rating: {rating}");

            
            strong = hasLength && hasUpper && hasLower &&
                     hasDigit && hasSpecial && noSpaces;

            if (!strong)
                Console.WriteLine("Password does not meet all rules. Try again.");

        } while (!strong);

        Console.WriteLine("\nPassword accepted! All rules passed.");
    }
}
