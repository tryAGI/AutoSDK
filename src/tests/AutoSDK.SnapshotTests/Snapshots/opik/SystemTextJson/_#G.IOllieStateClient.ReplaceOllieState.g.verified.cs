//HintName: G.IOllieStateClient.ReplaceOllieState.g.cs
#nullable enable

namespace G
{
    public partial interface IOllieStateClient
    {
        /// <summary>
        /// Replace ollie state<br/>
        /// Upload gzip-compressed SQLite DB file, replacing any existing state
        /// </summary>
        /// <param name="contentLength"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReplaceOllieStateAsync(

            object request,
            long? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace ollie state<br/>
        /// Upload gzip-compressed SQLite DB file, replacing any existing state
        /// </summary>
        /// <param name="contentLength"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReplaceOllieStateAsync(
            long? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}