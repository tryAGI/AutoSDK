//HintName: G.IChartsClient.OrgReadSingleSection.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsSection> OrgReadSingleSectionAsync(
            global::System.Guid sectionId,
            global::G.CustomChartsRequestBase request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.<br/>
        /// Default Value: {"days":0,"minutes":15,"hours":0}
        /// </param>
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsSection> OrgReadSingleSectionAsync(
            global::System.Guid sectionId,
            string? timezone = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::G.TimedeltaInput? stride = default,
            bool? omitData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}