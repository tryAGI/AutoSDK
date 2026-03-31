//HintName: G.ICorsClient.OptionsProjectLogsIdFetch.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/project_logs/{project_id}/fetch`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProjectLogsIdFetchAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}