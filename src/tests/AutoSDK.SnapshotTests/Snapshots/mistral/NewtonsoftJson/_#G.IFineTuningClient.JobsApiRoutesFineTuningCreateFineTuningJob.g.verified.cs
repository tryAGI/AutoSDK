//HintName: G.IFineTuningClient.JobsApiRoutesFineTuningCreateFineTuningJob.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::G.LegacyJobMetadataOut>> JobsApiRoutesFineTuningCreateFineTuningJobAsync(
            global::G.JobIn request,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="trainingFiles">
        /// Default Value: []
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </param>
        /// <param name="suffix">
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="autoStart">
        /// This field will be required in a future release.
        /// </param>
        /// <param name="invalidSampleSkipPercentage">
        /// Default Value: 0
        /// </param>
        /// <param name="jobType"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="repositories"></param>
        /// <param name="classifierTargets"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::G.LegacyJobMetadataOut>> JobsApiRoutesFineTuningCreateFineTuningJobAsync(
            global::G.FineTuneableModel model,
            global::G.AnyOf<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn> hyperparameters,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::G.TrainingFile>? trainingFiles = default,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles = default,
            string? suffix = default,
            global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item3>? integrations = default,
            bool? autoStart = default,
            double? invalidSampleSkipPercentage = default,
            global::G.FineTuneableModelType? jobType = default,
            global::System.Collections.Generic.IList<global::G.RepositoriesVariant1Item>? repositories = default,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetIn>? classifierTargets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}