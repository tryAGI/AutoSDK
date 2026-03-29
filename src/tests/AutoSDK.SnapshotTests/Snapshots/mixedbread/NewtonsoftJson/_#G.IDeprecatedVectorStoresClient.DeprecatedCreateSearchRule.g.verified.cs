//HintName: G.IDeprecatedVectorStoresClient.DeprecatedCreateSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Create search rule<br/>
        /// DEPRECATED: Use POST /stores/{store_identifier}/rules instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse> DeprecatedCreateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Create search rule<br/>
        /// DEPRECATED: Use POST /stores/{store_identifier}/rules instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="query">
        /// The query pattern to match
        /// </param>
        /// <param name="rules">
        /// The rules to apply on query matches
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse> DeprecatedCreateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            string query,
            global::System.Collections.Generic.IList<global::G.RulesItem> rules,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}