//HintName: G.Models.RuleSuitesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    public enum RuleSuitesResult
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
    public static class RuleSuitesResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuitesResult value)
        {
            return value switch
            {
                RuleSuitesResult.Pass => "pass",
                RuleSuitesResult.Fail => "fail",
                RuleSuitesResult.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuitesResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuitesResult.Pass,
                "fail" => RuleSuitesResult.Fail,
                "bypass" => RuleSuitesResult.Bypass,
                _ => null,
            };
        }
    }
}