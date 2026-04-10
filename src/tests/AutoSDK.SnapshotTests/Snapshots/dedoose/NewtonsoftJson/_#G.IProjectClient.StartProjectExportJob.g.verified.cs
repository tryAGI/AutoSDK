//HintName: G.IProjectClient.StartProjectExportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartProjectExportJob<br/>
        /// StartProjectExportJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartProjectExportJobAsync(

            global::G.StartProjectExportJobRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// StartProjectExportJob<br/>
        /// StartProjectExportJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="extension"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartProjectExportJobAsync(
            global::System.Guid projectId,
            string password,
            string email,
            string extension,
            string encryptedSymKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}