//HintName: G.IDubbingClient.Get4.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbed Transcript<br/>
        /// Returns transcript for the dub as an SRT or WEBVTT file.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ISO-693 language code to retrieve the transcript for. Use 'source' to fetch the transcript of the original media.
        /// </param>
        /// <param name="formatType">
        /// Format to return transcript in. For subtitles use either 'srt' or 'webvtt', and for a full transcript use 'json'. The 'json' format is not yet supported for Dubbing Studio.<br/>
        /// Default Value: srt
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.DubbingTranscriptResponseModel, string>> Get4Async(
            string dubbingId,
            string languageCode,
            global::G.GetDubbedTranscriptFileFormatType? formatType = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dubbed Transcript<br/>
        /// Returns transcript for the dub as an SRT or WEBVTT file.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ISO-693 language code to retrieve the transcript for. Use 'source' to fetch the transcript of the original media.
        /// </param>
        /// <param name="formatType">
        /// Format to return transcript in. For subtitles use either 'srt' or 'webvtt', and for a full transcript use 'json'. The 'json' format is not yet supported for Dubbing Studio.<br/>
        /// Default Value: srt
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.AnyOf<global::G.DubbingTranscriptResponseModel, string>>> Get4AsResponseAsync(
            string dubbingId,
            string languageCode,
            global::G.GetDubbedTranscriptFileFormatType? formatType = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}