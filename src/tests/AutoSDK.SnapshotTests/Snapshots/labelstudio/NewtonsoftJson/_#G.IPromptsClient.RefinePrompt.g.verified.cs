//HintName: G.IPromptsClient.RefinePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Refine a prompt version<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Refine a prompt version using a teacher model and save the refined prompt as a new version.
        /// </summary>
        /// <param name="async"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RefinedPromptResponse> RefinePromptAsync(
            int promptId,
            int versionId,

            global::G.RefinePromptRequestRequest request,
            bool? async = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Refine a prompt version<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Refine a prompt version using a teacher model and save the refined prompt as a new version.
        /// </summary>
        /// <param name="async"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="projectId">
        /// Project ID to target the refined prompt for
        /// </param>
        /// <param name="teacherModelName">
        /// Name of the model to use to refine the prompt
        /// </param>
        /// <param name="teacherModelProviderConnectionId">
        /// Model Provider Connection ID to use to refine the prompt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RefinedPromptResponse> RefinePromptAsync(
            int promptId,
            int versionId,
            int projectId,
            string teacherModelName,
            int teacherModelProviderConnectionId,
            bool? async = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}