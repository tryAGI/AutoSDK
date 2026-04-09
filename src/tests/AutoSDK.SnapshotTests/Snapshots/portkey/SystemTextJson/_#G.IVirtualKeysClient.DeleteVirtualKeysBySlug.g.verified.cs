//HintName: G.IVirtualKeysClient.DeleteVirtualKeysBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Delete a Virtual Key
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVirtualKeysBySlugAsync(
            string slug,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}