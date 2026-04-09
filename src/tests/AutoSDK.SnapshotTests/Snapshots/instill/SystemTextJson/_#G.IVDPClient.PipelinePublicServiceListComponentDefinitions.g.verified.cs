//HintName: G.IVdpClient.PipelinePublicServiceListComponentDefinitions.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
    {
        /// <summary>
        /// List component definitions<br/>
        /// Returns a paginated list of component definitions, regardless their type.<br/>
        /// This offers a single source of truth, with pagination and filter<br/>
        /// capabilities, for the components that might be used in a VDP pipeline.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListComponentDefinitionsResponse> PipelinePublicServiceListComponentDefinitionsAsync(
            int? pageSize = default,
            global::G.PipelinePublicServiceListComponentDefinitionsView? view = default,
            string? filter = default,
            int? page = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}