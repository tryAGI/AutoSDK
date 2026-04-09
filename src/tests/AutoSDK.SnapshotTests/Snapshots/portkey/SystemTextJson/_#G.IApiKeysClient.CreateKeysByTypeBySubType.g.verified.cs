//HintName: G.IApiKeysClient.CreateKeysByTypeBySubType.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::G.CreateKeysType type,
            global::G.CreateKeysSubType subType,

            global::G.CreateApiKeyObject request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.CreateKeysResponse>> CreateKeysByTypeBySubTypeAsResponseAsync(
            global::G.CreateKeysType type,
            global::G.CreateKeysSubType subType,

            global::G.CreateApiKeyObject request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::G.CreateKeysType type,
            global::G.CreateKeysSubType subType,
            string name,
            global::System.Collections.Generic.IList<string> scopes,
            string? description = default,
            string? workspaceId = default,
            global::System.Guid? userId = default,
            global::System.Collections.Generic.IList<global::G.CreateApiKeyObjectRateLimit>? rateLimits = default,
            global::G.UsageLimits? usageLimits = default,
            global::G.CreateApiKeyObjectDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? alertEmails = default,
            global::System.DateTime? expiresAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}