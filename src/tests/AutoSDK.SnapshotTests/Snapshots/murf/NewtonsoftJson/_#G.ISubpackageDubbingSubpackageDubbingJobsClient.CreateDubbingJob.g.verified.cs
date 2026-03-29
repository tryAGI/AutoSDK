//HintName: G.ISubpackageDubbingSubpackageDubbingJobsClient.CreateDubbingJob.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageDubbingSubpackageDubbingJobsClient
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiJobResponse> CreateDubbingJobAsync(

            global::G.CreateDubbingJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="sourceLocale">
        /// Source locale
        /// </param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="fileName"></param>
        /// <param name="priority">
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </param>
        /// <param name="webhookSecret"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiJobResponse> CreateDubbingJobAsync(
            global::System.Collections.Generic.IList<string> targetLocales,
            byte[]? file = default,
            string? fileUrl = default,
            string? sourceLocale = default,
            string? webhookUrl = default,
            string? fileName = default,
            global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority? priority = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}