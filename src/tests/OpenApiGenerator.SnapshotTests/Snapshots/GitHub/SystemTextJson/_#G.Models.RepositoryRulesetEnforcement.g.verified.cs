//HintName: G.Models.RepositoryRulesetEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    public abstract class RepositoryRulesetEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Disabled = "disabled";
        /// <summary>
        /// 
        /// </summary>
        public const string Active = "active";
        /// <summary>
        /// 
        /// </summary>
        public const string Evaluate = "evaluate";
    }
}