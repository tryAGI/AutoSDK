//HintName: G.IViewsClient.UpdateOrder.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Update order of views<br/>
        /// Update the order field of views based on the provided list of view IDs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateOrderAsync(

            global::G.ViewOrderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update order of views<br/>
        /// Update the order field of views based on the provided list of view IDs
        /// </summary>
        /// <param name="ids">
        /// A list of view IDs in the desired order.
        /// </param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateOrderAsync(
            global::System.Collections.Generic.IList<int> ids,
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}