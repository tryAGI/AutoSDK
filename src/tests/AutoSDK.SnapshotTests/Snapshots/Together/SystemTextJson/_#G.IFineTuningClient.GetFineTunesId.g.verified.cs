//HintName: G.IFineTuningClient.GetFineTunesId.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List job<br/>
        /// List the metadata for a single fine-tuning job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneResponse> GetFineTunesIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}