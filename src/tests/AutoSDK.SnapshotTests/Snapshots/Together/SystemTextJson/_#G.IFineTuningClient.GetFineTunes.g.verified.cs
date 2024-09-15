//HintName: G.IFineTuningClient.GetFineTunes.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List all jobs<br/>
        /// List the metadata for all fine-tuning jobs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneList> GetFineTunesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}