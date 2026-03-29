//HintName: G.IIdentitiesClient.DeleteIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// Delete Identity<br/>
        /// Delete an identity by its identifier key
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> DeleteIdentityAsync(
            string identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}