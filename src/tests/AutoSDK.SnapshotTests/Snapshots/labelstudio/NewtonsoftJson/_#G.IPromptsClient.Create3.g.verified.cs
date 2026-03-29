//HintName: G.IPromptsClient.Create3.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Run prompt inference<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Run a prompt inference.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelRun> Create3Async(
            int promptId,
            int versionId,

            global::G.ModelRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Run prompt inference<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Run a prompt inference.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="jobId">
        /// Job ID for inference job for a ModelRun e.g. Adala job ID
        /// </param>
        /// <param name="onlyMissingPredictions">
        /// When true, only tasks without successful predictions for this prompt version are submitted for inference.<br/>
        /// Default Value: false<br/>
        /// Included only in requests
        /// </param>
        /// <param name="organization"></param>
        /// <param name="predictionsUpdatedAt"></param>
        /// <param name="project"></param>
        /// <param name="projectSubset">
        /// * `All` - All<br/>
        /// * `HasGT` - HasGT<br/>
        /// * `Sample` - Sample
        /// </param>
        /// <param name="totalCorrectPredictions"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="totalTasks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelRun> Create3Async(
            int promptId,
            int versionId,
            bool onlyMissingPredictions,
            int project,
            string? jobId = default,
            int? organization = default,
            global::System.DateTime? predictionsUpdatedAt = default,
            global::G.ProjectSubsetEnum? projectSubset = default,
            int? totalCorrectPredictions = default,
            int? totalPredictions = default,
            int? totalTasks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}