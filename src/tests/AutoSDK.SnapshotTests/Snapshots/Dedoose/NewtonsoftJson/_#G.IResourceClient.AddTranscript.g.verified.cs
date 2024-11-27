//HintName: G.IResourceClient.AddTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// AddTranscript<br/>
        /// AddTranscript
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddTranscriptAsync(
            global::G.AddTranscriptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddTranscript<br/>
        /// AddTranscript
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="resourceId"></param>
        /// <param name="transcriptData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddTranscriptAsync(
            global::System.Guid projectId,
            global::System.Guid currentUserId,
            global::System.Guid resourceId,
            string transcriptData,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}