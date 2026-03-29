//HintName: G.ISubpackageApiKeysClient.CreateKeys.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeysCreateKeysResponse201> CreateKeysAsync(

            global::G.CreateKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="name">
        /// Name for the new API key
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeysCreateKeysResponse201> CreateKeysAsync(
            string name,
            double? limit = default,
            global::G.OneOf<global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset = default,
            bool? includeByokInLimit = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}