//HintName: G.IProxyClient.Proxyauto.g.cs
#nullable enable

namespace G
{
    public partial interface IProxyClient
    {
        /// <summary>
        /// Proxy a model to chat/completions or completions automatically<br/>
        /// Proxy a request to either chat/completions or completions automatically based on the model. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyautoAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy a model to chat/completions or completions automatically<br/>
        /// Proxy a request to either chat/completions or completions automatically based on the model. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyautoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}