//HintName: G.IRetentionRulesClient.FindRetentionRules.g.cs
#nullable enable

namespace G
{
    public partial interface IRetentionRulesClient
    {
        /// <summary>
        /// Find retention rules<br/>
        /// List retention rules for the caller's workspace. Defaults to active only.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="includeInactive">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetentionRulePagePublic> FindRetentionRulesAsync(
            int? page = default,
            int? size = default,
            bool? includeInactive = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}