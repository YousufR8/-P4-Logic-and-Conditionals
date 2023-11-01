using System;
using System.Linq;

class PasswordRating
{
    const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
    const string Digits = "0123456789";
    const string SpecialCharacters = "!@#$%^&*()_+";

    public static bool HasMinimumLength(string password, int minLength)
    {
        return password.Length >= minLength;
    }

    public static bool HasUppercase(string password)
    {
        foreach (char c in password)
        {
            if (UppercaseLetters.Contains(c))
            {
                return true;
            }
        }
        return false;
    }

    public static bool HasLowercase(string password)
    {
        foreach (char c in password)
        {
            if (LowercaseLetters.Contains(c))
            {
                return true;
            }
        }
        return false;
    }

    public static bool HasDigits(string password)
    {
        foreach (char c in password)
        {
            if (Digits.Contains(c))
            {
                return true;
            }
        }
        return false;
    }

    public static bool HasSpecialChars(string password)
    {
        foreach (char c in password)
        {
            if (SpecialCharacters.Contains(c))
            {
                return true;
            }
        }
        return false;
    }

    public static int RatePassword(string password, int minLength)
    {
        int score = 0;

        if (HasMinimumLength(password, minLength))
        {
            score++;
        }

        if (HasUppercase(password))
        {
            score++;
        }

        if (HasLowercase(password))
        {
            score++;
        }

        if (HasDigits(password))
        {
            score++;
        }

        if (HasSpecialChars(password))
        {
            score++;
        }

        return score;
    }

    static void Main()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        int minLength = 8;

        int passwordScore = RatePassword(password, minLength);

        Console.WriteLine("Password Rating:");

        switch (passwordScore)
        {
            case 5:
                Console.WriteLine("Excellent! Your password meets all criteria.");
                break;
            case 4:
                Console.WriteLine("Good job! Your password is strong.");
                break;
            case 3:
                Console.WriteLine("Fair. Your password could be stronger.");
                break;
            case 2:
                Console.WriteLine("Weak. Your password needs improvement.");
                break;
            case 1:
                Console.WriteLine("Very weak. Please make your password stronger.");
                break;
            default:
                Console.WriteLine("Password does not meet the minimum criteria.");
                break;
        }
        Console.ReadKey();
    }
}