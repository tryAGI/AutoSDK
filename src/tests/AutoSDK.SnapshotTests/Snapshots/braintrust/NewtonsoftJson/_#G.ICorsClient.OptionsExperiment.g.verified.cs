//HintName: G.ICorsClient.OptionsExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/experiment`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsExperimentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}