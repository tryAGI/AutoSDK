//HintName: G.IIdentitiesClient.ListIdentities.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// List Identities<br/>
        /// Get a list of all identities in the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// [DEPRECATED: Use X-Project-Id header instead] Filter identities by project ID
        /// </param>
        /// <param name="identifierKey"></param>
        /// <param name="identityType"></param>
        /// <param name="before">
        /// Identity ID cursor for pagination. Returns identities that come before this identity ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Identity ID cursor for pagination. Returns identities that come after this identity ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of identities to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for identities by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Identity>> ListIdentitiesAsync(
            string? name = default,
            string? projectId = default,
            string? identifierKey = default,
            global::G.IdentityType? identityType = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListIdentitiesOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}