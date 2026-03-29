//HintName: G.IPipelinesClient.SearchPipelinesApiV1PipelinesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Search Pipelines<br/>
        /// Search for pipelines by name, type, or project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="pipelineName"></param>
        /// <param name="pipelineType"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pipeline>> SearchPipelinesApiV1PipelinesGetAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? pipelineName = default,
            global::G.PipelineType? pipelineType = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}