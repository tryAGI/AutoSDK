//HintName: G.ITagClient.GetTagApplicationsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetTagApplicationsByProject<br/>
        /// GetTagApplicationsByProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TagAppDTO>> GetTagApplicationsByProjectAsync(
            global::G.GetTagApplicationsByProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTagApplicationsByProject<br/>
        /// GetTagApplicationsByProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TagAppDTO>> GetTagApplicationsByProjectAsync(
            global::System.Guid projectId,
            int page,
            int pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}