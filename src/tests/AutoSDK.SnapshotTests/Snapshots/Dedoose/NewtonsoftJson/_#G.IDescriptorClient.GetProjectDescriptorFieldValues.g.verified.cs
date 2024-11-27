//HintName: G.IDescriptorClient.GetProjectDescriptorFieldValues.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetProjectDescriptorFieldValues<br/>
        /// GetProjectDescriptorFieldValues
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DescriptorValueDTO>> GetProjectDescriptorFieldValuesAsync(
            global::G.GetProjectDescriptorFieldValuesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectDescriptorFieldValues<br/>
        /// GetProjectDescriptorFieldValues
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DescriptorValueDTO>> GetProjectDescriptorFieldValuesAsync(
            global::System.Guid projectId,
            int page,
            int pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}