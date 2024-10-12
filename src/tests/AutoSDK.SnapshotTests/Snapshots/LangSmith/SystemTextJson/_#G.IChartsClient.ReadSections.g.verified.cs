//HintName: G.IChartsClient.ReadSections.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Sections<br/>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomChartsSectionResponse>> ReadSectionsAsync(
            int? limit = 100,
            int? offset = 0,
            global::G.AnyOf<string, object>? titleContains = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids = default,
            global::G.AnyOf<string, object>? sortBy = default,
            global::G.AnyOf<bool?, object>? sortByDesc = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}