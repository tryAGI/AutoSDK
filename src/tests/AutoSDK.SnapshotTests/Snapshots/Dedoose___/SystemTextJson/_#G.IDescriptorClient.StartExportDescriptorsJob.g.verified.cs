//HintName: G.IDescriptorClient.StartExportDescriptorsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartExportDescriptorsJob<br/>
        /// StartExportDescriptorsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportDescriptorsJobAsync(
            global::G.StartExportDescriptorsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportDescriptorsJob<br/>
        /// StartExportDescriptorsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportDescriptorsJobAsync(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorIds,
            string fileExtension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}