//HintName: G.ISubpackageEndpointsClient.ListEndpoints.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEndpointsClient
    {
        /// <summary>
        /// List all endpoints for a model
        /// </summary>
        /// <param name="author"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EndpointsListEndpointsResponse200> ListEndpointsAsync(
            string author,
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}