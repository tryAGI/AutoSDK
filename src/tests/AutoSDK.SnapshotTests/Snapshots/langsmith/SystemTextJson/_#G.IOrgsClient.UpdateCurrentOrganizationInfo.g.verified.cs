//HintName: G.IOrgsClient.UpdateCurrentOrganizationInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(
            global::G.OrganizationUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}