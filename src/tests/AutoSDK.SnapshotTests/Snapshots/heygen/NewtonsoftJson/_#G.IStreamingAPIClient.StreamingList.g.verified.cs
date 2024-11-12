//HintName: G.IStreamingAPIClient.StreamingList.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.list<br/>
        /// streaming.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}