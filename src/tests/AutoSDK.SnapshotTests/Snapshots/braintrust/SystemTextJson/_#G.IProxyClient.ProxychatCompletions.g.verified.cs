//HintName: G.IProxyClient.ProxychatCompletions.g.cs
#nullable enable

namespace G
{
    public partial interface IProxyClient
    {
        /// <summary>
        /// Proxy chat/completions<br/>
        /// Proxy a chat/completions request to the specified model, converting its format as needed. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxychatCompletionsAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy chat/completions<br/>
        /// Proxy a chat/completions request to the specified model, converting its format as needed. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProxychatCompletionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}