namespace CheckAct.Utils.Extensions;

#nullable disable

public static class StringExtensions
{
    public static string NullIfEmpty(this string str)
        => string.IsNullOrEmpty(str) ? null : str;
}