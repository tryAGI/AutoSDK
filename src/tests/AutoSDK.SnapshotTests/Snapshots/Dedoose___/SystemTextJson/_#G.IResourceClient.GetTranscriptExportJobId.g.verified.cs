//HintName: G.IResourceClient.GetTranscriptExportJobId.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetTranscriptExportJobId<br/>
        /// GetTranscriptExportJobId
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTranscriptExportJobIdAsync(
            global::G.GetTranscriptExportJobIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTranscriptExportJobId<br/>
        /// GetTranscriptExportJobId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetTranscriptExportJobIdAsync(
            global::System.Guid projectId,
            global::System.Guid transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}