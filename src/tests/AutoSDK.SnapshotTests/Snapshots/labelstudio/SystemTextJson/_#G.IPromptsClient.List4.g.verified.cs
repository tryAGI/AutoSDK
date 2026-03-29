//HintName: G.IPromptsClient.List4.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Get inference run info<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get information (status, metadata, etc) about an existing inference run
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="parentModel"></param>
        /// <param name="project"></param>
        /// <param name="projectSubset"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelRun>> List4Async(
            int promptId,
            int versionId,
            string? ordering = default,
            int? parentModel = default,
            int? project = default,
            global::G.ApiPromptsVersionsInferenceRunsListProjectSubset? projectSubset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}