//HintName: G.IFilesClient.ListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns a list of files that belong to the user's organization.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesResponse> ListFilesAsync(
            string? purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}