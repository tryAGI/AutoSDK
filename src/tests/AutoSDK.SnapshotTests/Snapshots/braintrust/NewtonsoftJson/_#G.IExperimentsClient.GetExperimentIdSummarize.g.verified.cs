//HintName: G.IExperimentsClient.GetExperimentIdSummarize.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Summarize experiment<br/>
        /// Summarize experiment
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="summarizeScores">
        /// Whether to summarize the scores and metrics. If false (or omitted), only the metadata will be returned.
        /// </param>
        /// <param name="comparisonExperimentId">
        /// The experiment to compare against, if summarizing scores and metrics. If omitted, will fall back to the `base_exp_id` stored in the experiment metadata, and then to the most recent experiment run in the same project. Must pass `summarize_scores=true` for this id to be used
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeExperimentResponse> GetExperimentIdSummarizeAsync(
            global::System.Guid experimentId,
            bool? summarizeScores = default,
            global::System.Guid? comparisonExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}