//HintName: G.IDescriptorClient.DescriptorUpdateFieldOrders.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateFieldOrders.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorUpdateFieldOrdersResponse> DescriptorUpdateFieldOrdersAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Collections.Generic.IList<global::G.FieldVO>? fields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}