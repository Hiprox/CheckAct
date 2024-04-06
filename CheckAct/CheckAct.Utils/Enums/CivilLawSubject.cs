using System.Runtime.Serialization;
using FastEnumUtility;

namespace CheckAct.Utils.Enums;

/// <summary>
/// Субъект юридического права.
/// </summary>
public enum CivilLawSubject
{
    /// <summary>
    /// Физическое лицо.
    /// </summary>
    [Label("Физическое лицо"),
     EnumMember(Value = "INDIVIDUAL")]
    Individual,

    /// <summary>
    /// Юридическое лицо.
    /// </summary>
    [Label("Юридическое лицо"),
     EnumMember(Value = "LEGAL")]
    Legal
}