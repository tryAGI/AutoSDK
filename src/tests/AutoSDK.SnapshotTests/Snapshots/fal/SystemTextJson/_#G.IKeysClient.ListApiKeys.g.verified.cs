//HintName: G.IKeysClient.ListApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// List API Keys<br/>
        /// Returns a list of all API keys belonging to the authenticated user's workspace.<br/>
        /// **Requirements:**<br/>
        /// - Authentication required via admin API key<br/>
        /// **Key Features:**<br/>
        /// - View all API keys with their aliases and creation dates<br/>
        /// - Optionally expand to include creator information<br/>
        /// - Paginated results for workspaces with many keys<br/>
        /// **Expansion Options:**<br/>
        /// - `expand=creator_info`: Include creator_nickname and creator_email for each key<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit existing API keys<br/>
        /// - Find keys by alias<br/>
        /// - Monitor key creation activity<br/>
        /// - Build key management interfaces
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Available: creator_info (includes creator_nickname and creator_email)<br/>
        /// Example: [creator_info]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListApiKeysResponse> ListApiKeysAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}