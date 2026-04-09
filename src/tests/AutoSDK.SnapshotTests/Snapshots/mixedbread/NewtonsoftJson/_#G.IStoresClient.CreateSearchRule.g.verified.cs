//HintName: G.IStoresClient.CreateSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Create search rule<br/>
        /// Create a new search rule for a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_create: Search rule creation parameters<br/>
        /// Returns:<br/>
        ///     SearchRuleResponse: The created search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse> CreateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,

            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create search rule<br/>
        /// Create a new search rule for a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_create: Search rule creation parameters<br/>
        /// Returns:<br/>
        ///     SearchRuleResponse: The created search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="query">
        /// The query pattern to match
        /// </param>
        /// <param name="rules">
        /// The rules to apply on query matches
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse> CreateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            string query,
            global::System.Collections.Generic.IList<global::G.RulesItem3> rules,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}