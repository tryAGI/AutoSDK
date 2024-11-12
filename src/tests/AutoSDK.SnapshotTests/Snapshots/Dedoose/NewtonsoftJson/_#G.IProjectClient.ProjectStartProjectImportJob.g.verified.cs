//HintName: G.IProjectClient.ProjectStartProjectImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartProjectImportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProjectStartProjectImportJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? fileURI = default,
            string? password = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}