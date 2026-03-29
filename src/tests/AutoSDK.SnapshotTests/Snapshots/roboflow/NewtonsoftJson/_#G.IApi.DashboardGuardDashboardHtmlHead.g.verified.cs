//HintName: G.IApi.DashboardGuardDashboardHtmlHead.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Dashboard Guard
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DashboardGuardDashboardHtmlHeadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}