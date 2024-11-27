//HintName: G.IProjectClient.StartProjectImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartProjectImportJob<br/>
        /// StartProjectImportJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartProjectImportJobAsync(
            global::G.StartProjectImportJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartProjectImportJob<br/>
        /// StartProjectImportJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartProjectImportJobAsync(
            global::System.Guid projectId,
            string fileURI,
            string password,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}