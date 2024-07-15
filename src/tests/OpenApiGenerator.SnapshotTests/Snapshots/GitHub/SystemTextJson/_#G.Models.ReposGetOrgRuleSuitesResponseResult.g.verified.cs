//HintName: G.Models.ReposGetOrgRuleSuitesResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    public enum ReposGetOrgRuleSuitesResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        Pass,
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Bypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetOrgRuleSuitesResponseResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetOrgRuleSuitesResponseResult value)
        {
            return value switch
            {
                ReposGetOrgRuleSuitesResponseResult.Pass => "pass",
                ReposGetOrgRuleSuitesResponseResult.Fail => "fail",
                ReposGetOrgRuleSuitesResponseResult.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetOrgRuleSuitesResponseResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => ReposGetOrgRuleSuitesResponseResult.Pass,
                "fail" => ReposGetOrgRuleSuitesResponseResult.Fail,
                "bypass" => ReposGetOrgRuleSuitesResponseResult.Bypass,
                _ => null,
            };
        }
    }
}