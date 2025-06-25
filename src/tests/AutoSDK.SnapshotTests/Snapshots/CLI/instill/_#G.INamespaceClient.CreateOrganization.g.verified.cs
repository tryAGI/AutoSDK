//HintName: G.INamespaceClient.CreateOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Create an organization<br/>
        /// Creates an organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateOrganizationResponse> CreateOrganizationAsync(
            global::G.Organization request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization<br/>
        /// Creates an organization.
        /// </summary>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="profile">
        /// Profile.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateOrganizationResponse> CreateOrganizationAsync(
            global::G.OrganizationProfile profile,
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}