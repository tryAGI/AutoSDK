//HintName: G.IApi.FilesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the metadata for the given `File`.
        /// </summary>
        /// <param name="filesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> FilesGetAsync(
            string filesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}