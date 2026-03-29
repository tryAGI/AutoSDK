//HintName: G.IPausesClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IPausesClient
    {
        /// <summary>
        /// ✨ Update pause<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Partially update a pause entry by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectPk"></param>
        /// <param name="userPk"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pause> UpdateAsync(
            string id,
            int projectPk,
            int userPk,

            global::G.PatchedPauseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update pause<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Partially update a pause entry by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectPk"></param>
        /// <param name="userPk"></param>
        /// <param name="reason">
        /// Reason for pausing<br/>
        /// * `MANUAL` - Manual<br/>
        /// * `BEHAVIOR_BASED` - Behavior-based<br/>
        /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
        /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
        /// * `CUSTOM_SCRIPT` - Custom script
        /// </param>
        /// <param name="verboseReason">
        /// Detailed description of why the project is paused, will be readable by paused annotators
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pause> UpdateAsync(
            string id,
            int projectPk,
            int userPk,
            global::G.ReasonEnum? reason = default,
            string? verboseReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}