//HintName: G.IBetaClient.DeleteAgentDataApiV1BetaAgentDataItemIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Agent Data<br/>
        /// Delete agent data by ID.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> DeleteAgentDataApiV1BetaAgentDataItemIdDeleteAsync(
            string itemId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}