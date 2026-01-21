//HintName: G.IDubbingClient.CreateDubbingResourceByDubbingIdTranslate.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Translates All Or Some Segments And Languages<br/>
        /// Regenerate the translations for either the entire resource or the specified segments/languages. Will automatically transcribe missing transcriptions. Will not automatically regenerate the dubs.
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
        global::System.Threading.Tasks.Task<global::G.SegmentTranslationResponse> CreateDubbingResourceByDubbingIdTranslateAsync(
            string dubbingId,
            global::G.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Translates All Or Some Segments And Languages<br/>
        /// Regenerate the translations for either the entire resource or the specified segments/languages. Will automatically transcribe missing transcriptions. Will not automatically regenerate the dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="segments">
        /// Translate only this list of segments.
        /// </param>
        /// <param name="languages">
        /// Translate only these languages for each segment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentTranslationResponse> CreateDubbingResourceByDubbingIdTranslateAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string> languages,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}