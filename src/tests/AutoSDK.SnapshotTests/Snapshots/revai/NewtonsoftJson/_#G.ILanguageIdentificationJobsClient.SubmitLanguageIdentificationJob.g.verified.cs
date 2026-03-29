//HintName: G.ILanguageIdentificationJobsClient.SubmitLanguageIdentificationJob.g.cs
#nullable enable

namespace G
{
    public partial interface ILanguageIdentificationJobsClient
    {
        /// <summary>
        /// Submit Language Identification Job<br/>
        /// Starts an asynchronous language identification job for an audio file. Identifies the spoken language from 57+ supported languages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LanguageIdentificationJob> SubmitLanguageIdentificationJobAsync(

            global::G.SubmitLanguageIdentificationJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Language Identification Job<br/>
        /// Starts an asynchronous language identification job for an audio file. Identifies the spoken language from 57+ supported languages.
        /// </summary>
        /// <param name="mediaUrl">
        /// Direct download URL for the audio file
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="deleteAfterSeconds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LanguageIdentificationJob> SubmitLanguageIdentificationJobAsync(
            string? mediaUrl = default,
            string? metadata = default,
            string? callbackUrl = default,
            int? deleteAfterSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}