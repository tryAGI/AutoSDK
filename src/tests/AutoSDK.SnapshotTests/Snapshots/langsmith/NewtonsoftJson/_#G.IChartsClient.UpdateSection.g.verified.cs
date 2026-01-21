//HintName: G.IChartsClient.UpdateSection.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsSectionResponse> UpdateSectionAsync(
            global::System.Guid sectionId,
            global::G.CustomChartsSectionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsSectionResponse> UpdateSectionAsync(
            global::System.Guid sectionId,
            global::G.AnyOf<string, global::G.Missing>? title = default,
            global::G.AnyOf<string, global::G.Missing, object>? description = default,
            global::G.AnyOf<int?, global::G.Missing>? index = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}