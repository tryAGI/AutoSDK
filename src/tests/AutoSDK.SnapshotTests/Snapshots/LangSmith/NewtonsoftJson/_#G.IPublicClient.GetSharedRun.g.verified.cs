//HintName: G.IPublicClient.GetSharedRun.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Shared Run<br/>
        /// Get the shared run.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunPublicSchema> GetSharedRunAsync(
            global::System.Guid shareToken,
            bool? excludeS3StoredAttributes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}