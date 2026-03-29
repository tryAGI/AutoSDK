//HintName: G.IRetentionRulesClient.DeactivateRetentionRule.g.cs
#nullable enable

namespace G
{
    public partial interface IRetentionRulesClient
    {
        /// <summary>
        /// Deactivate retention rule<br/>
        /// Soft-deactivate a retention rule (sets enabled=false). Rules are never hard-deleted for audit trail.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeactivateRetentionRuleAsync(
            global::System.Guid ruleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}