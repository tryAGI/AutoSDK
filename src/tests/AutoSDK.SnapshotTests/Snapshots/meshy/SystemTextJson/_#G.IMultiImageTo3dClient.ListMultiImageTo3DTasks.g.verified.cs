//HintName: G.IMultiImageTo3dClient.ListMultiImageTo3DTasks.g.cs
#nullable enable

namespace G
{
    public partial interface IMultiImageTo3dClient
    {
        /// <summary>
        /// List Multi-Image to 3D tasks
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ImageTo3DTask>> ListMultiImageTo3DTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::G.ListMultiImageTo3DTasksSortBy? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}