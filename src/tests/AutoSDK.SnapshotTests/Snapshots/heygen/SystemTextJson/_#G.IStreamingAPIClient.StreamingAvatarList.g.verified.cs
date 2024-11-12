//HintName: G.IStreamingAPIClient.StreamingAvatarList.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming/avatar.list<br/>
        /// streaming/avatar.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingAvatarListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}