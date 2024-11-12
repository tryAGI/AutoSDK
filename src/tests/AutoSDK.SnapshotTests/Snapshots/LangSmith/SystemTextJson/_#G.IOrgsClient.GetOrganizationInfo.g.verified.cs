//HintName: G.IOrgsClient.GetOrganizationInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Organization Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Organization> GetOrganizationInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}