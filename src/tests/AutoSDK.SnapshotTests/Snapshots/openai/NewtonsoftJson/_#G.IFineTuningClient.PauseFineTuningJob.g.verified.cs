//HintName: G.IFineTuningClient.PauseFineTuningJob.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Pause a fine-tune job.
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> PauseFineTuningJobAsync(
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}