//HintName: G.IExperimentsClient.PatchExperimentId.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Partially update experiment<br/>
        /// Partially update an experiment object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Experiment> PatchExperimentIdAsync(
            global::System.Guid experimentId,

            global::G.PatchExperiment request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update experiment<br/>
        /// Partially update an experiment object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="name">
        /// Name of the experiment. Within a project, experiment names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the experiment
        /// </param>
        /// <param name="repoInfo">
        /// Metadata about the state of the repo when the experiment was created
        /// </param>
        /// <param name="baseExpId">
        /// Id of default base experiment to compare against when viewing this experiment
        /// </param>
        /// <param name="datasetId">
        /// Identifier of the linked dataset, or null if the experiment is not linked to a dataset
        /// </param>
        /// <param name="datasetVersion">
        /// Version number of the linked dataset the experiment was run against. This can be used to reproduce the experiment after the dataset has been modified.
        /// </param>
        /// <param name="public">
        /// Whether or not the experiment is public. Public experiments can be viewed by anybody inside or outside the organization
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the experiment
        /// </param>
        /// <param name="tags">
        /// A list of tags for the experiment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Experiment> PatchExperimentIdAsync(
            global::System.Guid experimentId,
            string? name = default,
            string? description = default,
            global::G.RepoInfo? repoInfo = default,
            global::System.Guid? baseExpId = default,
            global::System.Guid? datasetId = default,
            string? datasetVersion = default,
            bool? @public = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}