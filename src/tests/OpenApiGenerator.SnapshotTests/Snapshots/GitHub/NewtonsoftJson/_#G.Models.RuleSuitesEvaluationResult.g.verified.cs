//HintName: G.Models.RuleSuitesEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuitesEvaluationResult
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
    public static class RuleSuitesEvaluationResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuitesEvaluationResult value)
        {
            return value switch
            {
                RuleSuitesEvaluationResult.Pass => "pass",
                RuleSuitesEvaluationResult.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuitesEvaluationResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuitesEvaluationResult.Pass,
                "fail" => RuleSuitesEvaluationResult.Fail,
                _ => null,
            };
        }
    }
}