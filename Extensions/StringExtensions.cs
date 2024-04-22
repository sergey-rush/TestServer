using System;

namespace RuRuServer.Extensions;

public static class StringExtensions
{
    private static Random random = new Random();
    public static string RandomString(this int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}