//HintName: G.IFeedbackClient.FeedbackCreateFeedbackCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Create<br/>
        /// Add feedback to a call or object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackCreateRes> FeedbackCreateFeedbackCreatePostAsync(

            global::G.FeedbackCreateReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Create<br/>
        /// Add feedback to a call or object.
        /// </summary>
        /// <param name="id">
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="creator"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
        /// <param name="annotationRef"></param>
        /// <param name="runnableRef"></param>
        /// <param name="callRef"></param>
        /// <param name="triggerRef"></param>
        /// <param name="queueId">
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackCreateRes> FeedbackCreateFeedbackCreatePostAsync(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string? id = default,
            string? creator = default,
            string? annotationRef = default,
            string? runnableRef = default,
            string? callRef = default,
            string? triggerRef = default,
            string? queueId = default,
            string? wbUserId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}