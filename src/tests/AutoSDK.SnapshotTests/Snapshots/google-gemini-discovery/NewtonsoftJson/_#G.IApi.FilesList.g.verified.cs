//HintName: G.IApi.FilesList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Lists the metadata for `File`s owned by the requesting project.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesResponse> FilesListAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}