//HintName: G.IResourceClient.ResourceUpdateResourceAndData.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateResourceAndData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="fileURL"></param>
        /// <param name="length"></param>
        /// <param name="isLocked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceUpdateResourceAndDataAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            string? title = default,
            string? description = default,
            string? fileURL = default,
            int? length = default,
            bool? isLocked = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}