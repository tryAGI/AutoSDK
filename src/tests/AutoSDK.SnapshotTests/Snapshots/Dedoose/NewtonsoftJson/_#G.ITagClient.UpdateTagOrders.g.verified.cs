//HintName: G.ITagClient.UpdateTagOrders.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTagOrders<br/>
        /// UpdateTagOrders
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagOrdersAsync(
            global::G.UpdateTagOrdersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateTagOrders<br/>
        /// UpdateTagOrders
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagOrdersAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.Tag> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}