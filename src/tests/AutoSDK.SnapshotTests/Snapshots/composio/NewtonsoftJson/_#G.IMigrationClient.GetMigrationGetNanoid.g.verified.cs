//HintName: G.IMigrationClient.GetMigrationGetNanoid.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationClient
    {
        /// <summary>
        /// Get NanoId from UUID<br/>
        /// Convert a legacy UUID to its corresponding NanoId for migration purposes. This endpoint facilitates the transition from UUID-based identifiers to the more compact NanoId format used in the v3 API.
        /// </summary>
        /// <param name="uuid">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="type">
        /// Example: CONNECTED_ACCOUNT
        /// </param>
        /// <param name="xApiKey">
        /// Your Composio API key used for authentication<br/>
        /// Example: sk_123456789abcdef
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMigrationGetNanoidResponse> GetMigrationGetNanoidAsync(
            global::System.Guid uuid,
            global::G.GetMigrationGetNanoidType type,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}