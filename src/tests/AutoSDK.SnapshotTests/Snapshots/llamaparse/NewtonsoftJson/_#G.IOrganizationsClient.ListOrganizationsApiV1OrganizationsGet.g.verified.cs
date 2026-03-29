//HintName: G.IOrganizationsClient.ListOrganizationsApiV1OrganizationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Organizations<br/>
        /// List organizations for a user.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Organization>> ListOrganizationsApiV1OrganizationsGetAsync(
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}