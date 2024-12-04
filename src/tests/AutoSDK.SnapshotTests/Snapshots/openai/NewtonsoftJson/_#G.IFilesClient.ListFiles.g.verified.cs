//HintName: G.IFilesClient.ListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns a list of files.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="limit">
        /// Default Value: 10000
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesResponse> ListFilesAsync(
            string? purpose = default,
            int? limit = default,
            global::G.ListFilesOrder? order = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}