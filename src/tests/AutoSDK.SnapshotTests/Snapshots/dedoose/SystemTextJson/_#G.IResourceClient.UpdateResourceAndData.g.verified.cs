//HintName: G.IResourceClient.UpdateResourceAndData.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateResourceAndData<br/>
        /// UpdateResourceAndData
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateResourceAndDataAsync(
            global::G.UpdateResourceAndDataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateResourceAndData<br/>
        /// UpdateResourceAndData
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="fileURL"></param>
        /// <param name="length"></param>
        /// <param name="isLocked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateResourceAndDataAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            string title,
            string description,
            string fileURL,
            int length,
            bool isLocked,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}