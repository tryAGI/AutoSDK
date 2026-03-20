//HintName: G.ISingleClient.GetCurrentOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current organization.<br/>
        /// Returns the current organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentOrganizationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}