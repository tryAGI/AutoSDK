//HintName: G.Models.RuleSuiteResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    public enum RuleSuiteResult2
    {
        /// <summary>
        /// 
        /// </summary>
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteResult2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteResult2 value)
        {
            return value switch
            {
                RuleSuiteResult2.Bypass => "bypass",
                RuleSuiteResult2.Fail => "fail",
                RuleSuiteResult2.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteResult2? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => RuleSuiteResult2.Bypass,
                "fail" => RuleSuiteResult2.Fail,
                "pass" => RuleSuiteResult2.Pass,
                _ => null,
            };
        }
    }
}