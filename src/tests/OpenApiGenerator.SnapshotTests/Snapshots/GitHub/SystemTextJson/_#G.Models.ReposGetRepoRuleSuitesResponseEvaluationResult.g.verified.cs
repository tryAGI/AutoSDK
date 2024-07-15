//HintName: G.Models.ReposGetRepoRuleSuitesResponseEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    public enum ReposGetRepoRuleSuitesResponseEvaluationResult
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
    public static class ReposGetRepoRuleSuitesResponseEvaluationResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetRepoRuleSuitesResponseEvaluationResult value)
        {
            return value switch
            {
                ReposGetRepoRuleSuitesResponseEvaluationResult.Pass => "pass",
                ReposGetRepoRuleSuitesResponseEvaluationResult.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesResponseEvaluationResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => ReposGetRepoRuleSuitesResponseEvaluationResult.Pass,
                "fail" => ReposGetRepoRuleSuitesResponseEvaluationResult.Fail,
                _ => null,
            };
        }
    }
}