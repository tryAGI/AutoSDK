//HintName: G.IDeprecatedVectorStoresClient.DeprecatedUpdateSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Update a search rule<br/>
        /// DEPRECATED: Use PUT /stores/{store_identifier}/rules/{rule_id} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse> DeprecatedUpdateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Update a search rule<br/>
        /// DEPRECATED: Use PUT /stores/{store_identifier}/rules/{rule_id} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule to update
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
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse> DeprecatedUpdateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,
            string? query = default,
            global::System.Collections.Generic.IList<global::G.RulesVariant1Item>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}