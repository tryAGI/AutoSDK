//HintName: G.ICaptionsClient.GetCaptions.g.cs
#nullable enable

namespace G
{
    public partial interface ICaptionsClient
    {
        /// <summary>
        /// Get Captions<br/>
        /// Returns caption output for a transcription job in SRT or VTT format.
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/x-subrip
        /// </param>
        /// <param name="speakerChannel"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCaptionsAsync(
            string id,
            global::G.GetCaptionsAccept? accept = default,
            int? speakerChannel = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}