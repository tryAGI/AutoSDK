//HintName: G.Models.RuleSuiteEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    public enum RuleSuiteEvaluationResult
    {
        /// <summary>
        /// 
        /// </summary>
        Pass,
        /// <summary>
        /// 
        /// </summary>
        Fail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteEvaluationResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteEvaluationResult value)
        {
            return value switch
            {
                RuleSuiteEvaluationResult.Pass => "pass",
                RuleSuiteEvaluationResult.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteEvaluationResult ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuiteEvaluationResult.Pass,
                "fail" => RuleSuiteEvaluationResult.Fail,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}