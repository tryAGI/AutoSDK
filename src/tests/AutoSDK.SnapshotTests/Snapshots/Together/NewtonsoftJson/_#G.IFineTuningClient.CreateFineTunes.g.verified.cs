//HintName: G.IFineTuningClient.CreateFineTunes.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneResponse> CreateFineTunesAsync(
            global::G.Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="batchSize">
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="learningRate">
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 1E-05F
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEpochs">
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="trainingType"></param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="wandbApiKey">
        /// API key for Weights &amp; Biases integration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneResponse> CreateFineTunesAsync(
            string model,
            string trainingFile,
            int? batchSize = default,
            float? learningRate = default,
            int? nCheckpoints = default,
            int? nEpochs = default,
            int? nEvals = default,
            string? suffix = default,
            global::G.OneOf<global::G.FullTrainingType, global::G.LoRATrainingType>? trainingType = default,
            string? validationFile = default,
            string? wandbApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}