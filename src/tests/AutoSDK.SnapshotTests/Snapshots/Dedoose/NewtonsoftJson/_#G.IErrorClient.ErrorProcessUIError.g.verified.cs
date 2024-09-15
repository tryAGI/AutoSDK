//HintName: G.IErrorClient.ErrorProcessUIError.g.cs
#nullable enable

namespace G
{
    public partial interface IErrorClient
    {
        /// <summary>
        /// ProcessUIError.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="workspace"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="currentTarget"></param>
        /// <param name="stacktrace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ErrorProcessUIErrorResponse> ErrorProcessUIErrorAsync(
            string? token = default,
            string? projectId = default,
            string? userId = default,
            string? workspace = default,
            string? errorCode = default,
            string? message = default,
            string? currentTarget = default,
            string? stacktrace = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}