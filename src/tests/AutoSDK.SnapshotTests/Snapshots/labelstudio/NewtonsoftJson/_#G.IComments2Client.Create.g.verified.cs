//HintName: G.IComments2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IComments2Client
    {
        /// <summary>
        /// ✨ Create comment<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a comment for a specific annotation ID.
        /// </summary>
        /// <param name="expandCreatedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MaybeExpandedComment> CreateAsync(

            global::G.CommentRequest request,
            bool? expandCreatedBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Create comment<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a comment for a specific annotation ID.
        /// </summary>
        /// <param name="expandCreatedBy"></param>
        /// <param name="annotation"></param>
        /// <param name="classifications">
        /// Classifications applied by a reviewer or annotator
        /// </param>
        /// <param name="draft"></param>
        /// <param name="isResolved">
        /// True if the comment is resolved
        /// </param>
        /// <param name="regionRef">
        /// Set if this comment is related to a specific part of the annotation. Normally contains region ID and control name.
        /// </param>
        /// <param name="text">
        /// Reviewer or annotator comment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MaybeExpandedComment> CreateAsync(
            bool? expandCreatedBy = default,
            int? annotation = default,
            object? classifications = default,
            int? draft = default,
            bool? isResolved = default,
            object? regionRef = default,
            string? text = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}