//HintName: G.IAnnotationQueuesClient.UpdateAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::G.AnnotationQueueUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDataset = default,
            int? numReviewersPerItem = default,
            bool? enableReservations = default,
            int? reservationMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}