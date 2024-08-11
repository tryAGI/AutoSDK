//HintName: G.Models.RuleSuiteEvaluationResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteEvaluationResult2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteEvaluationResult2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteEvaluationResult2 value)
        {
            return value switch
            {
                RuleSuiteEvaluationResult2.Pass => "pass",
                RuleSuiteEvaluationResult2.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteEvaluationResult2? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuiteEvaluationResult2.Pass,
                "fail" => RuleSuiteEvaluationResult2.Fail,
                _ => null,
            };
        }
    }
}