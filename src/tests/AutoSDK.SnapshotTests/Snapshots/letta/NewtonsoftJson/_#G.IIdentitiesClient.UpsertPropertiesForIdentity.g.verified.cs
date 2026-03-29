//HintName: G.IIdentitiesClient.UpsertPropertiesForIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// Upsert Properties For Identity
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> UpsertPropertiesForIdentityAsync(
            string identityId,

            global::System.Collections.Generic.IList<global::G.IdentityProperty> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}