//HintName: G.IExperimentsClient.PostExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create experiment<br/>
        /// Create a new experiment. If there is an existing experiment in the project with the same name as the one specified in the request, will return the existing experiment unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Experiment> PostExperimentAsync(

            global::G.CreateExperiment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment<br/>
        /// Create a new experiment. If there is an existing experiment in the project with the same name as the one specified in the request, will return the existing experiment unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the experiment belongs under
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
        /// <param name="ensureNew">
        /// Normally, creating an experiment with the same name as an existing experiment will return the existing one un-modified. But if `ensure_new` is true, registration will generate a new experiment with a unique name in case of a conflict.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Experiment> PostExperimentAsync(
            global::System.Guid projectId,
            string? name = default,
            string? description = default,
            global::G.RepoInfo? repoInfo = default,
            global::System.Guid? baseExpId = default,
            global::System.Guid? datasetId = default,
            string? datasetVersion = default,
            bool? @public = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? ensureNew = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}