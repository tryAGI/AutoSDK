//HintName: G.IPingClient.Ping.g.cs
#nullable enable

namespace G
{
    public partial interface IPingClient
    {
        /// <summary>
        /// Ping<br/>
        /// Check if the API is running
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PingResponse> PingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}