//HintName: G.IV2Client.UploadFileMultipartApiV2ParseUploadPost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Upload File Multipart<br/>
        /// Upload and parse a file using multipart/form-data.<br/>
        /// Send the file as a `file` field and parsing configuration as a<br/>
        /// `configuration` JSON string field.<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseJobResponse> UploadFileMultipartApiV2ParseUploadPostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}