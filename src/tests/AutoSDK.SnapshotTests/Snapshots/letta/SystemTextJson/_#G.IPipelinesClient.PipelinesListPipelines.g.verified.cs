//HintName: G.IPipelinesClient.PipelinesListPipelines.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// List Pipelines<br/>
        /// List all pipelines for the organization with optional filtering
        /// </summary>
        /// <param name="search"></param>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesListPipelinesResponse> PipelinesListPipelinesAsync(
            string? search = default,
            string? integrationType = default,
            string? integrationId = default,
            global::G.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}