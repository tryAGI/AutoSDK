//HintName: G.IDescriptorClient.StartImportDescriptorsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartImportDescriptorsJob<br/>
        /// StartImportDescriptorsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportDescriptorsJobAsync(
            global::G.StartImportDescriptorsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartImportDescriptorsJob<br/>
        /// StartImportDescriptorsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorInfos"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportDescriptorsJobAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::G.DescriptorInfo> descriptorInfos,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}