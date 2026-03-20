//HintName: G.IChartsClient.OrgReadSections.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Read Sections<br/>
        /// Get all sections for the tenant.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="titleContains"></param>
        /// <param name="ids"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomChartsSectionResponse>> OrgReadSectionsAsync(
            int? limit = default,
            int? offset = default,
            string? titleContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            string? sortBy = default,
            bool? sortByDesc = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}