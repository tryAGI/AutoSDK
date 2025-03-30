//HintName: G.IAnnotationQueuesClient.ExportAnnotationQueueArchivedRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Export Annotation Queue Archived Runs
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAnnotationQueueArchivedRunsAsync(
            global::System.Guid queueId,
            global::G.ExportAnnotationQueueRunsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Export Annotation Queue Archived Runs
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAnnotationQueueArchivedRunsAsync(
            global::System.Guid queueId,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}