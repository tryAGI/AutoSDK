//HintName: G.IDubbingClient.CreateDubbingResourceByDubbingIdDub.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Dubs All Or Some Segments And Languages<br/>
        /// Regenerate the dubs for either the entire resource or the specified segments/languages. Will automatically transcribe and translate any missing transcriptions and translations.
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
        global::System.Threading.Tasks.Task<global::G.SegmentDubResponse> CreateDubbingResourceByDubbingIdDubAsync(
            string dubbingId,
            global::G.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Dubs All Or Some Segments And Languages<br/>
        /// Regenerate the dubs for either the entire resource or the specified segments/languages. Will automatically transcribe and translate any missing transcriptions and translations.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="segments">
        /// Dub only this list of segments.
        /// </param>
        /// <param name="languages">
        /// Dub only these languages for each segment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentDubResponse> CreateDubbingResourceByDubbingIdDubAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string> languages,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}