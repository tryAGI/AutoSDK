//HintName: G.IAnnotationQueuesClient.CreateAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueSchema> CreateAnnotationQueueAsync(
            global::G.AnnotationQueueCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes">
        /// Default Value: 1
        /// </param>
        /// <param name="id"></param>
        /// <param name="rubricItems"></param>
        /// <param name="rubricInstructions"></param>
        /// <param name="sessionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueSchema> CreateAnnotationQueueAsync(
            string name,
            string? description = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            global::System.Guid? defaultDataset = default,
            int? numReviewersPerItem = default,
            bool? enableReservations = default,
            int? reservationMinutes = default,
            global::System.Guid? id = default,
            global::System.Collections.Generic.IList<global::G.AnnotationQueueRubricItemSchema>? rubricItems = default,
            string? rubricInstructions = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sessionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}