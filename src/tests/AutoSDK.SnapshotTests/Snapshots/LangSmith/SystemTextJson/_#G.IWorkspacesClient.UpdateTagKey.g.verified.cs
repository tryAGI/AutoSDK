//HintName: G.IWorkspacesClient.UpdateTagKey.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagKey> UpdateTagKeyAsync(
            global::System.Guid tagKeyId,
            global::G.TagKeyUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagKey> UpdateTagKeyAsync(
            global::System.Guid tagKeyId,
            global::G.AnyOf<string, object>? key = default,
            global::G.AnyOf<string, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}