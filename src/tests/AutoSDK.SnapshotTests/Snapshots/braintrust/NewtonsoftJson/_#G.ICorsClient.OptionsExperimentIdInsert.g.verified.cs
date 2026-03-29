//HintName: G.ICorsClient.OptionsExperimentIdInsert.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/experiment/{experiment_id}/insert`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsExperimentIdInsertAsync(
            global::System.Guid experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}