using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Extensions;
public static class PasswordExtensions
{
    // Extension method to generate password hash
    public static string GeneratePasswordHash(this string password)
    {
        // Generate a random salt
        string salt = BCrypt.Net.BCrypt.GenerateSalt();

        // Generate the password hash with the salt
        return BCrypt.Net.BCrypt.HashPassword(password, salt);
    }

    // Extension method to validate the password
    public static bool ValidatePassword(this string enteredPassword, string storedHash)
    {
        // Validate the entered password by comparing it with the stored hash
        return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
    }
}
