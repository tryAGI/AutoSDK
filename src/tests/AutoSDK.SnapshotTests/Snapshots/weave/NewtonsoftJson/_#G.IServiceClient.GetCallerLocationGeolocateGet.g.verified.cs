//HintName: G.IServiceClient.GetCallerLocationGeolocateGet.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Get Caller Location<br/>
        /// Lookup the geographic location of a user based on their IP address.<br/>
        /// This API exists for debugging purposes and may not be available in the future.
        /// </summary>
        /// <param name="ip">
        /// IP address to geolocate, defaults to client IP address
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GeolocationRes> GetCallerLocationGeolocateGetAsync(
            string? ip = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}