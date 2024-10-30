//HintName: G.IVDPClient.PipelinePublicServiceListComponentDefinitions.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListComponentDefinitionsResponse> PipelinePublicServiceListComponentDefinitionsAsync(
            int? pageSize = default,
            global::G.PipelinePublicServiceListComponentDefinitionsView? view = default,
            string? filter = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}