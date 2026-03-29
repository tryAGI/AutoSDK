//HintName: G.IExperimentsClient.GetExperimentId.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get experiment<br/>
        /// Get an experiment object by its id
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Experiment> GetExperimentIdAsync(
            global::System.Guid experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}