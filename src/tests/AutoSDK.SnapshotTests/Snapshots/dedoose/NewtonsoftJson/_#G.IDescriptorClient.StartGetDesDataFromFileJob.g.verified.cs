//HintName: G.IDescriptorClient.StartGetDesDataFromFileJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartGetDesDataFromFileJob<br/>
        /// StartGetDesDataFromFileJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetDesDataFromFileJobAsync(
            global::G.StartGetDesDataFromFileJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartGetDesDataFromFileJob<br/>
        /// StartGetDesDataFromFileJob
        /// </summary>
        /// <param name="localFileURL"></param>
        /// <param name="setId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetDesDataFromFileJobAsync(
            string localFileURL,
            global::System.Guid setId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}