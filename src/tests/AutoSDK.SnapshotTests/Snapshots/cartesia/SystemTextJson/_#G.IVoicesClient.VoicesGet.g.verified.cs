//HintName: G.IVoicesClient.VoicesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> VoicesGetAsync(
            global::G.VoicesGetCartesiaVersion cartesiaVersion,
            string id,
            global::System.Collections.Generic.IList<global::G.VoiceExpandOptions>? expand = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}