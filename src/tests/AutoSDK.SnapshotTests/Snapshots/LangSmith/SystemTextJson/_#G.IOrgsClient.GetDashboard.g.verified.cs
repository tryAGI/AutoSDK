//HintName: G.IOrgsClient.GetDashboard.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationDashboardSchema> GetDashboardAsync(
            global::G.OrganizationDashboardType type,
            global::G.AnyOf<global::G.OrganizationDashboardColorScheme?, object> colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}