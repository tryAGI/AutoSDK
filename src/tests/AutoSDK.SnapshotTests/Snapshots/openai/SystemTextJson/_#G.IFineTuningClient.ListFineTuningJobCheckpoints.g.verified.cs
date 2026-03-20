//HintName: G.IFineTuningClient.ListFineTuningJobCheckpoints.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List checkpoints for a fine-tuning job.
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFineTuningJobCheckpointsResponse> ListFineTuningJobCheckpointsAsync(
            string fineTuningJobId,
            string? after = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}