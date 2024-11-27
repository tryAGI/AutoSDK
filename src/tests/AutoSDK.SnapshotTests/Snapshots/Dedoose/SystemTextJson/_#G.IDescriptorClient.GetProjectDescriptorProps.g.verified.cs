//HintName: G.IDescriptorClient.GetProjectDescriptorProps.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetProjectDescriptorProps<br/>
        /// GetProjectDescriptorProps
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectDescriptorProps> GetProjectDescriptorPropsAsync(
            global::G.GetProjectDescriptorPropsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectDescriptorProps<br/>
        /// GetProjectDescriptorProps
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectDescriptorProps> GetProjectDescriptorPropsAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}