//HintName: G.IDubbingClient.GetDubbingByDubbingIdTranscriptByLanguageCode.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Transcript For Dub<br/>
        /// Returns transcript for the dub as an SRT file.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ID of the language.
        /// </param>
        /// <param name="formatType">
        /// Format to use for the subtitle file, either 'srt' or 'webvtt'
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDubbingByDubbingIdTranscriptByLanguageCodeAsync(
            string dubbingId,
            string languageCode,
            global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}