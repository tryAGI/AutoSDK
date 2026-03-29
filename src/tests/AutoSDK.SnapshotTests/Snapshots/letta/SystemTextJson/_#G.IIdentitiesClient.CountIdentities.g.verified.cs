//HintName: G.IIdentitiesClient.CountIdentities.g.cs
#nullable enable

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// Count Identities<br/>
        /// Get count of all identities for a user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<int> CountIdentitiesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}