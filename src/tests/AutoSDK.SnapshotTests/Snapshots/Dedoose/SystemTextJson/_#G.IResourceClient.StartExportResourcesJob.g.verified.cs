//HintName: G.IResourceClient.StartExportResourcesJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartExportResourcesJob<br/>
        /// StartExportResourcesJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportResourcesJobAsync(
            global::G.StartExportResourcesJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportResourcesJob<br/>
        /// StartExportResourcesJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportResourcesJobAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds,
            bool includeDescriptorInfo,
            bool includeCodeCounts,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}