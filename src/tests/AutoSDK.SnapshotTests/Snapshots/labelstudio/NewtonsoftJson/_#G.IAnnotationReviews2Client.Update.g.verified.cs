//HintName: G.IAnnotationReviews2Client.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationReviews2Client
    {
        /// <summary>
        /// ✨ Update review<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific review by ID. Only allowed for organizations with reviewing features enabled.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationReview> UpdateAsync(
            int id,

            global::G.PatchedAnnotationReviewRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update review<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific review by ID. Only allowed for organizations with reviewing features enabled.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accepted">
        /// Accepted or rejected (if false) flag
        /// </param>
        /// <param name="annotation">
        /// Corresponding annotation
        /// </param>
        /// <param name="comment">
        /// Included only in requests
        /// </param>
        /// <param name="lastAnnotationHistory"></param>
        /// <param name="removeFromQueue"></param>
        /// <param name="result"></param>
        /// <param name="startedAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationReview> UpdateAsync(
            int id,
            string? comment,
            bool? accepted = default,
            int? annotation = default,
            int? lastAnnotationHistory = default,
            bool? removeFromQueue = default,
            object? result = default,
            global::System.DateTime? startedAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}