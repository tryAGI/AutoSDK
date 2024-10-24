//HintName: G.IFilesClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of pipeline file instances.
        /// </summary>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAny> IndexAsync(
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}