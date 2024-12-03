//HintName: G.IDescriptorClient.UpdateFieldOrders.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateFieldOrders<br/>
        /// UpdateFieldOrders
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateFieldOrdersAsync(
            global::G.UpdateFieldOrdersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateFieldOrders<br/>
        /// UpdateFieldOrders
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateFieldOrdersAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.FieldVO> fields,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}