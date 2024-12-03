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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProcessUIErrorAsync(
            global::G.ProcessUIErrorRequest request,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}