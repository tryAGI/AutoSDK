//HintName: G.IApi.GetOrgDataSourcesInfoStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Org Data Sources Info
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConnectorsDataSources> GetOrgDataSourcesInfoStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesGetAsync(
            string organizationId,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}