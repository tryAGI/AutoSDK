//HintName: G.Models.RuleSuiteEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    public abstract class RuleSuiteEvaluationResult
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pass = "pass";
        /// <summary>
        /// 
        /// </summary>
        public const string Fail = "fail";
    }
}