//HintName: G.IErrorClient.ProcessUIError.g.cs
#nullable enable

namespace G
{
    public partial interface IErrorClient
    {
        /// <summary>
        /// ProcessUIError<br/>
        /// ProcessUIError
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProcessUIErrorAsync(

            global::G.ProcessUIErrorRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ProcessUIError<br/>
        /// ProcessUIError
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="workspace"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="currentTarget"></param>
        /// <param name="stacktrace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProcessUIErrorAsync(
            string projectId,
            string userId,
            string workspace,
            string errorCode,
            string message,
            string currentTarget,
            string stacktrace,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}