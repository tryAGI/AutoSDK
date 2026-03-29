//HintName: G.IExperimentsClient.GetExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get experiment by ID
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExperimentResponseBody> GetExperimentAsync(
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}