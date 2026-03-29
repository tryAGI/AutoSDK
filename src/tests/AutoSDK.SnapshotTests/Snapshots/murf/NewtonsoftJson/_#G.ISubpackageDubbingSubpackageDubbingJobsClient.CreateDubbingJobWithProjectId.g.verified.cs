//HintName: G.ISubpackageDubbingSubpackageDubbingJobsClient.CreateDubbingJobWithProjectId.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageDubbingSubpackageDubbingJobsClient
    {
        /// <summary>
        /// Create With Project Id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiJobResponse> CreateDubbingJobWithProjectIdAsync(

            global::G.CreateDubbingJobWithProjectIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create With Project Id
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="projectId">
        /// Your Project Id
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="fileName"></param>
        /// <param name="priority">
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </param>
        /// <param name="webhookSecret"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiJobResponse> CreateDubbingJobWithProjectIdAsync(
            string projectId,
            byte[]? file = default,
            string? fileUrl = default,
            string? webhookUrl = default,
            string? fileName = default,
            global::G.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority? priority = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}