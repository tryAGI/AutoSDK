//HintName: G.IDatasetsClient.DeleteVersionTag.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete version tag<br/>
        /// Remove a tag from a dataset version. The version itself is not deleted, only the tag reference.
        /// </summary>
        /// <param name="versionHash"></param>
        /// <param name="tag"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVersionTagAsync(
            string versionHash,
            string tag,
            global::System.Guid id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}