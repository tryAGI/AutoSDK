//HintName: G.IDescriptorClient.GetProjectDescriptorsPaged.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetProjectDescriptorsPaged<br/>
        /// GetProjectDescriptorsPaged
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Descriptor>> GetProjectDescriptorsPagedAsync(
            global::G.GetProjectDescriptorsPagedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectDescriptorsPaged<br/>
        /// GetProjectDescriptorsPaged
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Descriptor>> GetProjectDescriptorsPagedAsync(
            global::System.Guid projectId,
            int page,
            int pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}