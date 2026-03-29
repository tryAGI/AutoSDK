//HintName: G.Models.OpenAIFinetuneJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for OpenAI, Azure OpenAI and VertexAI.
    /// </summary>
    public sealed partial class OpenAIFinetuneJob
    {
        /// <summary>
        /// The base model to finetune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The training file to use for the finetune job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The validation file to use for the finetune job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// The suffix to append to the fine-tuned model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Suffix { get; set; } = default!;

        /// <summary>
        /// Hyperparameters for the finetune job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIFinetuneJobMethod Method { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJob" /> class.
        /// </summary>
        /// <param name="model">
        /// The base model to finetune
        /// </param>
        /// <param name="trainingFile">
        /// The training file to use for the finetune job
        /// </param>
        /// <param name="suffix">
        /// The suffix to append to the fine-tuned model name
        /// </param>
        /// <param name="method">
        /// Hyperparameters for the finetune job
        /// </param>
        /// <param name="validationFile">
        /// The validation file to use for the finetune job
        /// </param>
        public OpenAIFinetuneJob(
            string model,
            string trainingFile,
            string suffix,
            global::G.OpenAIFinetuneJobMethod method,
            string? validationFile)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.ValidationFile = validationFile;
            this.Suffix = suffix ?? throw new global::System.ArgumentNullException(nameof(suffix));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJob" /> class.
        /// </summary>
        public OpenAIFinetuneJob()
        {
        }
    }
}