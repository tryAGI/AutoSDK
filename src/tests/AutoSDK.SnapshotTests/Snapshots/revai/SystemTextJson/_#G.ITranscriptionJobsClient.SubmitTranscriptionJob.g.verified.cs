//HintName: G.ITranscriptionJobsClient.SubmitTranscriptionJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptionJobsClient
    {
        /// <summary>
        /// Submit Transcription Job<br/>
        /// Starts an asynchronous job to transcribe speech-to-text for a media file. Media files can be specified by URL or uploaded directly.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionJob> SubmitTranscriptionJobAsync(

            global::G.SubmitTranscriptionJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Transcription Job<br/>
        /// Starts an asynchronous job to transcribe speech-to-text for a media file. Media files can be specified by URL or uploaded directly.
        /// </summary>
        /// <param name="mediaUrl">
        /// Direct download URL for the media file
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="skipDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="skipPunctuation">
        /// Default Value: false
        /// </param>
        /// <param name="removeDisfluencies">
        /// Default Value: false
        /// </param>
        /// <param name="filterProfanity">
        /// Default Value: false
        /// </param>
        /// <param name="speakerChannelsCount"></param>
        /// <param name="customVocabularyId"></param>
        /// <param name="deleteAfterSeconds"></param>
        /// <param name="customVocabularies"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionJob> SubmitTranscriptionJobAsync(
            string mediaUrl,
            string? metadata = default,
            string? callbackUrl = default,
            global::G.SubmitTranscriptionJobRequestLanguage? language = default,
            bool? skipDiarization = default,
            bool? skipPunctuation = default,
            bool? removeDisfluencies = default,
            bool? filterProfanity = default,
            int? speakerChannelsCount = default,
            string? customVocabularyId = default,
            int? deleteAfterSeconds = default,
            global::System.Collections.Generic.IList<global::G.CustomVocabulary>? customVocabularies = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}