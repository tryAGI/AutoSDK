//HintName: G.IDeprecatedVectorStoresClient.DeprecatedDeleteSpecificSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Delete a specific rule from rules array<br/>
        /// DEPRECATED: Use DELETE /stores/{store_identifier}/rules/{rule_id}/specific instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted> DeprecatedDeleteSpecificSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Delete a specific rule from rules array<br/>
        /// DEPRECATED: Use DELETE /stores/{store_identifier}/rules/{rule_id}/specific instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule
        /// </param>
        /// <param name="rule">
        /// The specific rule to delete from the rules array
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted> DeprecatedDeleteSpecificSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,
            global::G.Rule rule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}