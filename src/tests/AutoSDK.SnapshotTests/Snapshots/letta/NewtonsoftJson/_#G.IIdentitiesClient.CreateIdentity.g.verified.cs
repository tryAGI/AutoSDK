//HintName: G.IIdentitiesClient.CreateIdentity.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// Create Identity
        /// </summary>
        /// <param name="xProject">
        /// The project slug to associate with the identity (cloud only).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Identity> CreateIdentityAsync(

            global::G.IdentityCreate request,
            string? xProject = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Identity
        /// </summary>
        /// <param name="xProject">
        /// The project slug to associate with the identity (cloud only).
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
        /// <param name="projectId">
        /// The project id of the identity, if applicable.
        /// </param>
        /// <param name="properties">
        /// List of properties associated with the identity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Identity> CreateIdentityAsync(
            string identifierKey,
            string name,
            global::G.IdentityType identityType,
            string? xProject = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<global::G.IdentityProperty>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}