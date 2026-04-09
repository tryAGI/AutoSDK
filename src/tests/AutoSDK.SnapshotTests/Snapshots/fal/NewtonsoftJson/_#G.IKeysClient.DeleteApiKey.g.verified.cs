//HintName: G.IKeysClient.DeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Delete API Key<br/>
        /// Deletes an API key by its ID. This action is irreversible.<br/>
        /// **Requirements:**<br/>
        /// - Authentication required via admin API key<br/>
        /// - Key must belong to the authenticated user's workspace<br/>
        /// **Key Features:**<br/>
        /// - Permanently revoke API key access<br/>
        /// - Idempotent operation (safe to retry)<br/>
        /// - Optional Idempotency-Key header for safe retries<br/>
        /// **Important:**<br/>
        /// - This action cannot be undone<br/>
        /// - Any applications using this key will immediately lose access<br/>
        /// - Returns 204 even if the key doesn't exist (idempotent behavior)<br/>
        /// **Common Use Cases:**<br/>
        /// - Revoke compromised keys<br/>
        /// - Clean up unused keys<br/>
        /// - Implement key rotation (delete old, create new)<br/>
        /// - Offboard team members
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier of the API key to delete<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteApiKeyAsync(
            string keyId,
            string? idempotencyKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}