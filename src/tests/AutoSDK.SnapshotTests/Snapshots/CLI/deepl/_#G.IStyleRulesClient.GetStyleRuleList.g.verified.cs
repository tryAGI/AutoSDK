//HintName: G.IStyleRulesClient.GetStyleRuleList.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Retrieve a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StyleRuleList> GetStyleRuleListAsync(
            string styleId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.StyleRuleList>> GetStyleRuleListAsResponseAsync(
            string styleId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}