//HintName: G.IAgentConfigsClient.GetBlueprintHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Get blueprint history<br/>
        /// Retrieves paginated blueprint history for a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlueprintPageHistory> GetBlueprintHistoryAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}