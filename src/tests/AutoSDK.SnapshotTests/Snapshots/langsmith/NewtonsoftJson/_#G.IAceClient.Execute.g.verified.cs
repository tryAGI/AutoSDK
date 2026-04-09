//HintName: G.IAceClient.Execute.g.cs
#nullable enable

namespace G
{
    public partial interface IAceClient
    {
        /// <summary>
        /// Execute<br/>
        /// Execute some custom code for testing purposes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteAsync(

            global::G.BodyExecuteApiV1AceExecutePost request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute<br/>
        /// Execute some custom code for testing purposes.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="code"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteAsync(
            global::System.Collections.Generic.IList<object> args,
            string code,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}