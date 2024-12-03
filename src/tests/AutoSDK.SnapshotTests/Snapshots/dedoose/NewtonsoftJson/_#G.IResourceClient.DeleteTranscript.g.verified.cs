//HintName: G.IResourceClient.DeleteTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// DeleteTranscript<br/>
        /// DeleteTranscript
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTranscriptAsync(
            global::G.DeleteTranscriptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteTranscript<br/>
        /// DeleteTranscript
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTranscriptAsync(
            global::G.ResourceTranscript transcript,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}