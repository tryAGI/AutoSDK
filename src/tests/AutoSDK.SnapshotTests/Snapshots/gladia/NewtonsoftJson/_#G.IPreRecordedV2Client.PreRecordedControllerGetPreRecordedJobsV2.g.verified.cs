//HintName: G.IPreRecordedV2Client.PreRecordedControllerGetPreRecordedJobsV2.g.cs
#nullable enable

namespace G
{
    public partial interface IPreRecordedV2Client
    {
        /// <summary>
        /// Get pre recorded jobs based on query parameters
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-03-28
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPreRecordedResponse> PreRecordedControllerGetPreRecordedJobsV2Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::G.PreRecordedControllerGetPreRecordedJobsV2Statu>? status = default,
            object? customMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}