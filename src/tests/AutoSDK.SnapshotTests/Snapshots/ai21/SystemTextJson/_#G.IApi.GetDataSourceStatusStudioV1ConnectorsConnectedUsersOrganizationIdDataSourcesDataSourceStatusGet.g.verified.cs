//HintName: G.IApi.GetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Data Source Status
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="dataSource"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConnectorsStatus> GetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetAsync(
            string organizationId,
            string dataSource,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}