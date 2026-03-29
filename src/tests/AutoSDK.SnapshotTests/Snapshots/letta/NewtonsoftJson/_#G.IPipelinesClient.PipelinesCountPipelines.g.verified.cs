//HintName: G.IPipelinesClient.PipelinesCountPipelines.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Count Pipelines<br/>
        /// Get the total count of pipelines, optionally filtered by project and search
        /// </summary>
        /// <param name="search"></param>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesCountPipelinesResponse> PipelinesCountPipelinesAsync(
            string? search = default,
            string? integrationType = default,
            string? integrationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}