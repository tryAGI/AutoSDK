//HintName: G.IDescriptorClient.StartExportFieldsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartExportFieldsJob<br/>
        /// StartExportFieldsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportFieldsJobAsync(
            global::G.StartExportFieldsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportFieldsJob<br/>
        /// StartExportFieldsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportFieldsJobAsync(
            global::System.Guid projectId,
            global::System.Guid setId,
            string fileExtension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}