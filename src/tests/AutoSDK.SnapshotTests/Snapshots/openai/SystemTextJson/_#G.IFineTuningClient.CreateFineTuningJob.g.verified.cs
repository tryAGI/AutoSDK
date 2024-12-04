//HintName: G.IFineTuningClient.CreateFineTuningJob.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::G.CreateFineTuningJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="model">
        /// The name of the model to fine-tune. You can select one of the<br/>
        /// [supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="trainingFile">
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input) or [completions](/docs/api-reference/fine-tuning/completions-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job.
        /// </param>
        /// <param name="suffix">
        /// A string of up to 64 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </param>
        /// <param name="validationFile">
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="seed">
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?> model,
            string trainingFile,
            global::G.CreateFineTuningJobRequestHyperparameters? hyperparameters = default,
            string? suffix = default,
            string? validationFile = default,
            global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? integrations = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}