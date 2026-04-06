//HintName: G.IApi.GetOrders.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets a list of orders
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetOrdersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}