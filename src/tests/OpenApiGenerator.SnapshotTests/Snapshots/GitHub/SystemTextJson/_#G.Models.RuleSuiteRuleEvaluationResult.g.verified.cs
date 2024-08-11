//HintName: G.Models.RuleSuiteRuleEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the evaluation of the individual rule.
    /// </summary>
    public enum RuleSuiteRuleEvaluationResult
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
    public static class RuleSuiteRuleEvaluationResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteRuleEvaluationResult value)
        {
            return value switch
            {
                RuleSuiteRuleEvaluationResult.Pass => "pass",
                RuleSuiteRuleEvaluationResult.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteRuleEvaluationResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuiteRuleEvaluationResult.Pass,
                "fail" => RuleSuiteRuleEvaluationResult.Fail,
                _ => null,
            };
        }
    }
}