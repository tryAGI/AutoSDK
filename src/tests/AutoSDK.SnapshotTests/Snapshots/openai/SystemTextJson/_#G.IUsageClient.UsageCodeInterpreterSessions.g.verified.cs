//HintName: G.IUsageClient.UsageCodeInterpreterSessions.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get code interpreter sessions usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageResponse> UsageCodeInterpreterSessionsAsync(
            int startTime,
            int? endTime = default,
            global::G.UsageCodeInterpreterSessionsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}