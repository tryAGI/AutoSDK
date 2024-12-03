//HintName: G.IRunClient.TriggerRule.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Trigger Rule<br/>
        /// Trigger a run rule manually.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunRulesSchema> TriggerRuleAsync(
            global::System.Guid ruleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}