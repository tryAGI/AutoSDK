//HintName: G.IWorkspacesClient.CreateTagKey.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create Tag Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagKey> CreateTagKeyAsync(
            global::G.TagKeyCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tag Key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagKey> CreateTagKeyAsync(
            string key,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}