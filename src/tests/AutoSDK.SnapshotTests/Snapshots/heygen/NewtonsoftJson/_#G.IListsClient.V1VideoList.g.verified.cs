//HintName: G.IListsClient.V1VideoList.g.cs
#nullable enable

namespace G
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/video.list<br/>
        /// v1/video.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1VideoListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}