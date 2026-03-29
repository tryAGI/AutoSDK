//HintName: G.IBetaClient.DeleteFileApiV1BetaFilesFileIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete a file from the project.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFileApiV1BetaFilesFileIdDeleteAsync(
            global::System.Guid fileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}