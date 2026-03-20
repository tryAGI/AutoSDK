//HintName: G.IApi.GatewayHealthGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the health of Universal API service<br/>
        /// Get the health of this Gateway service.<br/>
        /// .. # noqa: DAR201
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GatewayHealthGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}