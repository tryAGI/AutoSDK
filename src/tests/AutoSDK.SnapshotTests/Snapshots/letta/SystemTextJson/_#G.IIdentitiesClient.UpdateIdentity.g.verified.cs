//HintName: G.IIdentitiesClient.UpdateIdentity.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// Modify Identity
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Identity> UpdateIdentityAsync(
            string identityId,

            global::G.IdentityUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Identity
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="identifierKey">
        /// External, user-generated identifier key of the identity.
        /// </param>
        /// <param name="name">
        /// The name of the identity.
        /// </param>
        /// <param name="identityType">
        /// The type of the identity.
        /// </param>
        /// <param name="properties">
        /// List of properties associated with the identity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Identity> UpdateIdentityAsync(
            string identityId,
            string? identifierKey = default,
            string? name = default,
            global::G.IdentityType? identityType = default,
            global::System.Collections.Generic.IList<global::G.IdentityProperty>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}