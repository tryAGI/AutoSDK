//HintName: G.IFineTuningClient.GetFinetuneDownload.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Download model<br/>
        /// Download a compressed fine-tuned model or checkpoint to local disk.
        /// </summary>
        /// <param name="ftId"></param>
        /// <param name="checkpointStep"></param>
        /// <param name="output"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneDownloadResult> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            string? output = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}