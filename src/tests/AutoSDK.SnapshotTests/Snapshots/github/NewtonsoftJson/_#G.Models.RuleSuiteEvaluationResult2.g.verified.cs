//HintName: G.Models.RuleSuiteEvaluationResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`. Null if no rules with `evaluate` enforcement status were run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteEvaluationResult2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bypass")]
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
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
                RuleSuiteEvaluationResult2.Bypass => "bypass",
                RuleSuiteEvaluationResult2.Fail => "fail",
                RuleSuiteEvaluationResult2.Pass => "pass",
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
                "bypass" => RuleSuiteEvaluationResult2.Bypass,
                "fail" => RuleSuiteEvaluationResult2.Fail,
                "pass" => RuleSuiteEvaluationResult2.Pass,
                _ => null,
            };
        }
    }
}