//HintName: G.IRunClient.GetLastAppliedRule.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Get Last Applied Rule<br/>
        /// Get the last applied rule.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RuleLogSchema> GetLastAppliedRuleAsync(
            global::System.Guid ruleId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}