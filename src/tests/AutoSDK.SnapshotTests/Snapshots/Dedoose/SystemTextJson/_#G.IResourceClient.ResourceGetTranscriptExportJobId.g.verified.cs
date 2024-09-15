//HintName: G.IResourceClient.ResourceGetTranscriptExportJobId.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetTranscriptExportJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceGetTranscriptExportJobIdAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid transcriptId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}