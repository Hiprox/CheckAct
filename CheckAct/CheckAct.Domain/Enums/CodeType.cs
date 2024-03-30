using System.Runtime.Serialization;
using FastEnumUtility;

namespace CheckAct.Domain.Enums;

/// <summary>
/// Перечисление для типов кодов.
/// </summary>
public enum CodeType
{
    /// <summary>
    /// ОГРНИП.
    /// </summary>
    [Label("ОГРНИП")]
    [EnumMember(Value = "OGRNIP")]
    Ogrnip,

    /// <summary>
    /// ОГРН.
    /// </summary>
    [Label("ОГРН")]
    [EnumMember(Value = "OGRN")]
    Ogrn,

    /// <summary>
    /// КПП.
    /// </summary>
    [Label("КПП")]
    [EnumMember(Value = "KPP")]
    Kpp
}