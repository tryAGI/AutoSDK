//HintName: G.IOrganizationClient.ListOrganizations.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List organizations<br/>
        /// Returns a paginated list of organizations.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListOrganizationsResponse> ListOrganizationsAsync(
            int pageSize = default,
            string? pageToken = default,
            global::G.ListOrganizationsView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}