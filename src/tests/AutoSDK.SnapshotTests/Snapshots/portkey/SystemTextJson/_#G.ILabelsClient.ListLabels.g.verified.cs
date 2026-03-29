//HintName: G.ILabelsClient.ListLabels.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// List labels<br/>
        /// Returns a list of labels based on filters
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="search"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListLabelsResponse> ListLabelsAsync(
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            string? search = default,
            int? currentPage = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}