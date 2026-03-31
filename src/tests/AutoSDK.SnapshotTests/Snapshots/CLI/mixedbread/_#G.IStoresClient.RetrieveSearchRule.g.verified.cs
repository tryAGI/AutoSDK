//HintName: G.IStoresClient.RetrieveSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Get a search rule<br/>
        /// Get a search rule by ID.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule to retrieve<br/>
        /// Returns:<br/>
        ///     SearchRuleResponse: The search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse> RetrieveSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}