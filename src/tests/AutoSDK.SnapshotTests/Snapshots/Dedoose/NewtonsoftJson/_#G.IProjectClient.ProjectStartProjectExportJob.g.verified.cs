//HintName: G.IProjectClient.ProjectStartProjectExportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartProjectExportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="extension"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProjectStartProjectExportJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? password = default,
            string? email = default,
            string? extension = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}