//HintName: G.IProjectClient.GetProjectImportJobExceptions.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetProjectImportJobExceptions<br/>
        /// GetProjectImportJobExceptions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectImportJobExceptionsAsync(
            global::G.GetProjectImportJobExceptionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectImportJobExceptions<br/>
        /// GetProjectImportJobExceptions
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectImportJobExceptionsAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}