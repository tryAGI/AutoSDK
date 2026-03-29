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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The training file to use for the finetune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The validation file to use for the finetune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// The suffix to append to the fine-tuned model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suffix { get; set; }

        /// <summary>
        /// Hyperparameters for the finetune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIFinetuneJobMethod Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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