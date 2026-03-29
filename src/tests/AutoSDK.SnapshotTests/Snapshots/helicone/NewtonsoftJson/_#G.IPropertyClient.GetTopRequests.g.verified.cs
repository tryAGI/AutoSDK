//HintName: G.IPropertyClient.GetTopRequests.g.cs
#nullable enable

namespace G
{
    public partial interface IPropertyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultValueStringCountNumberArrayString> GetTopRequestsAsync(
            string propertyKey,

            global::G.TimeFilterRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyKey"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultValueStringCountNumberArrayString> GetTopRequestsAsync(
            string propertyKey,
            global::G.TimeFilterRequestTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}