//HintName: G.ISubpackageEndpointsClient.ListEndpointsZdr.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEndpointsClient
    {
        /// <summary>
        /// Preview the impact of ZDR on the available endpoints
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EndpointsListEndpointsZdrResponse200> ListEndpointsZdrAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}