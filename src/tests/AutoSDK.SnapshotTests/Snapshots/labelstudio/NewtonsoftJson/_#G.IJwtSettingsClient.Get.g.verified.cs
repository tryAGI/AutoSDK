//HintName: G.IJwtSettingsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IJwtSettingsClient
    {
        /// <summary>
        /// Retrieve JWT Settings<br/>
        /// Retrieve JWT settings for the currently active organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LSEJWTSettings> GetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}