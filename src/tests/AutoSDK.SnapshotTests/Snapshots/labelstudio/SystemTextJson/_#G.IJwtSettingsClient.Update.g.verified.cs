//HintName: G.IJwtSettingsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IJwtSettingsClient
    {
        /// <summary>
        /// Update JWT Settings<br/>
        /// Update JWT settings for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LSEJWTSettings> UpdateAsync(

            global::G.LSEJWTSettingsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update JWT Settings<br/>
        /// Update JWT settings for the currently active organization.
        /// </summary>
        /// <param name="apiTokenTtlDays"></param>
        /// <param name="apiTokensEnabled">
        /// Enable JWT API token authentication for this organization
        /// </param>
        /// <param name="legacyApiTokensEnabled">
        /// Enable legacy API token authentication for this organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LSEJWTSettings> UpdateAsync(
            int apiTokenTtlDays,
            bool? apiTokensEnabled = default,
            bool? legacyApiTokensEnabled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}