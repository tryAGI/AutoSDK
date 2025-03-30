//HintName: G.IDubbingClient.CreateDubbingResourceByDubbingIdTranscribe.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Transcribes Segments<br/>
        /// Regenerate the transcriptions for the specified segments. Does not automatically regenerate translations or dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentTranscriptionResponse> CreateDubbingResourceByDubbingIdTranscribeAsync(
            string dubbingId,
            global::G.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transcribes Segments<br/>
        /// Regenerate the transcriptions for the specified segments. Does not automatically regenerate translations or dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="segments">
        /// Transcribe this specific list of segments.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentTranscriptionResponse> CreateDubbingResourceByDubbingIdTranscribeAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}