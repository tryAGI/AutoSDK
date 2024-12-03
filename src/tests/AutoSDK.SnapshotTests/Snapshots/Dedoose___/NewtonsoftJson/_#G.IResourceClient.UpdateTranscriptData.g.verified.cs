//HintName: G.IResourceClient.UpdateTranscriptData.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateTranscriptData<br/>
        /// UpdateTranscriptData
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTranscriptDataAsync(
            global::G.UpdateTranscriptDataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateTranscriptData<br/>
        /// UpdateTranscriptData
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTranscriptDataAsync(
            global::G.ResourceTranscript transcript,
            string transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> syncItems,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}