//HintName: G.IStoresClient.DeleteSearchRule.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Delete a search rule<br/>
        /// Delete a search rule by ID.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule to delete<br/>
        /// Returns:<br/>
        ///     SearchRuleDeleted: The deleted search rule details
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted> DeleteSearchRuleAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}