//HintName: G.IResourceClient.ResourceAddTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// AddTranscript.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="resourceId"></param>
        /// <param name="transcriptData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceAddTranscriptAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? currentUserId = default,
            global::System.Guid? resourceId = default,
            string? transcriptData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}