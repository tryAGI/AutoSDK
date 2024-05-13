//HintName: G.Models.CreateFineTuningJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequest
    {
        /// <summary>
        /// The name of the model to fine-tune. You can select one of the
        /// [supported models](/docs/guides/fine-tuning/what-models-can-be-fine-tuned).
        /// <br/>Example: gpt-3.5-turbo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains training data.
        /// See [upload file](/docs/api-reference/files/upload) for how to upload a file.
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public CreateFineTuningJobRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// A string of up to 18 characters that will be added to your fine-tuned model name.
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-3.5-turbo:openai:custom-model-name:7p4lURel`.
        /// <br/>Default Value: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.
        /// If you provide this file, the data is used to generate validation
        /// metrics periodically during fine-tuning. These metrics can be viewed in
        /// the fine-tuning results file.
        /// The same data should not be present in both train and validation files.
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}