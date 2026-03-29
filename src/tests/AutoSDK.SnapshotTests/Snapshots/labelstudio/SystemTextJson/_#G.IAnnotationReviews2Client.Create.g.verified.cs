//HintName: G.IAnnotationReviews2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationReviews2Client
    {
        /// <summary>
        /// ✨ Create review<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a review for a specific annotation ID. Only allowed for organizations with reviewing features enabled.
        /// </summary>
        /// <param name="asyncPostprocess"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationReview> CreateAsync(

            global::G.AnnotationReviewRequest request,
            bool? asyncPostprocess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Create review<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a review for a specific annotation ID. Only allowed for organizations with reviewing features enabled.
        /// </summary>
        /// <param name="asyncPostprocess"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationReview> CreateAsync(
            int annotation,
            string? comment,
            bool? asyncPostprocess = default,
            bool? accepted = default,
            int? lastAnnotationHistory = default,
            bool? removeFromQueue = default,
            object? result = default,
            global::System.DateTime? startedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}