//HintName: G.IDubbingClient.GetDubbingByDubbingIdTranscriptsByLanguageCodeFormatByFormatType.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {

        /// <summary>
        /// Retrieve A Transcript<br/>
        /// Fetch the transcript for one of the languages in a dub.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ISO-693 language code to retrieve the transcript for. Use 'source' to fetch the transcript of the original media.
        /// </param>
        /// <param name="formatType">
        /// Format to return transcript in. For subtitles use either 'srt' or 'webvtt', and for a full transcript use 'json'. The 'json' format is not yet supported for Dubbing Studio.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DubbingTranscriptsResponseModel> GetDubbingByDubbingIdTranscriptsByLanguageCodeFormatByFormatTypeAsync(
            string dubbingId,
            string languageCode,
            global::G.GetDubbingTranscriptsFormatType formatType,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}