//HintName: G.IIdentitiesClient.ListBlocksForIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// List Blocks For Identity<br/>
        /// Get all blocks associated with the specified identity.
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Block ID cursor for pagination. Returns blocks that come before this block ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Block ID cursor for pagination. Returns blocks that come after this block ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of blocks to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BlockResponse>> ListBlocksForIdentityAsync(
            string identityId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListBlocksForIdentityOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}