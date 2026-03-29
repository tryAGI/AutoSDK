//HintName: G.IStoresClient.UpdateSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Update a search rule<br/>
        /// Update a search rule by ID.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule to update<br/>
        ///     rule_update: SearchRuleUpdateParams object containing the fields to update<br/>
        /// Returns:<br/>
        ///     SearchRuleResponse: The updated search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse> UpdateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,

            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a search rule<br/>
        /// Update a search rule by ID.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule to update<br/>
        ///     rule_update: SearchRuleUpdateParams object containing the fields to update<br/>
        /// Returns:<br/>
        ///     SearchRuleResponse: The updated search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
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
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse> UpdateSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            string? query = default,
            global::System.Collections.Generic.IList<global::G.RulesVariant1Item2>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}