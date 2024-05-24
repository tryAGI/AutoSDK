//HintName: G.Models.RuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    public abstract class RuleSuiteResult
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pass = "pass";
        /// <summary>
        /// 
        /// </summary>
        public const string Fail = "fail";
        /// <summary>
        /// 
        /// </summary>
        public const string Bypass = "bypass";
    }
}