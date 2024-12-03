//HintName: G.IFineTuningClient.RetrieveFineTuningJob.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get info about a fine-tuning job.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> RetrieveFineTuningJobAsync(
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}