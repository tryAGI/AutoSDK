//HintName: G.IPublicClient.GetSharedRunById.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Shared Run By Id<br/>
        /// Get the shared run.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunPublicSchema> GetSharedRunByIdAsync(
            global::System.Guid id,
            global::System.Guid shareToken,
            bool? excludeS3StoredAttributes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}