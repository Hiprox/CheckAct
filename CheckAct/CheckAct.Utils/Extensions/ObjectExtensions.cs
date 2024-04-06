using System.ComponentModel.DataAnnotations;

namespace CheckAct.Utils.Extensions;

public static class ObjetExtensions
{
    public static void ValidateProperties(this object obj)
    {
        var context = new ValidationContext(obj);
        Validator.ValidateObject(obj, context, true);
    }
}