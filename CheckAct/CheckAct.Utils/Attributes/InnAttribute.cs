using System.ComponentModel.DataAnnotations;
using CheckAct.Utils.Enums;

namespace CheckAct.Utils.Attributes;

public class InnAttribute : RegularExpressionAttribute
{
    public InnAttribute() : base(@"^(\d{10}|\d{12})$")
    {
        ErrorMessage = "ИНН должен быть последовательностью из 10/12 цифр.";
    }

    public InnAttribute(CivilLawSubject civilLawSubject)
        : base(civilLawSubject == CivilLawSubject.Individual
            ? @"^\d{12}$"
            : @"^\d{10}$")
    {
        ErrorMessage = civilLawSubject == CivilLawSubject.Individual
            ? "ИНН физического лица должен быть последовательностью из 12 цифр."
            : "ИНН юридического лица должен быть последовательностью из 10 цифр.";
    }
}