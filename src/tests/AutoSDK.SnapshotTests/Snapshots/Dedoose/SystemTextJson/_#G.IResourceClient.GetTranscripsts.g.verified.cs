//HintName: G.IResourceClient.GetTranscripsts.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetTranscripsts<br/>
        /// GetTranscripsts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ResourceTranscript>> GetTranscripstsAsync(
            global::G.GetTranscripstsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTranscripsts<br/>
        /// GetTranscripsts
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ResourceTranscript>> GetTranscripstsAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}