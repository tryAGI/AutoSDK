//HintName: G.IDashboardClient.ApiProjectsDashboardRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// Get dashboard data for project<br/>
        /// Get dashboard data for project, including annotations and tasks stats.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ApiProjectsDashboardRetrieveResponse> ApiProjectsDashboardRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}