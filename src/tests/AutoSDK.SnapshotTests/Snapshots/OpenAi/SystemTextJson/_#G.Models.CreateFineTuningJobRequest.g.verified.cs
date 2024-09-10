//HintName: G.Models.CreateFineTuningJobRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequest
    {
        /// <summary>
        /// The name of the model to fine-tune. You can select one of the<br/>
        /// [supported models](/docs/guides/fine-tuning/which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?> Model { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input) or [completions](/docs/api-reference/fine-tuning/completions-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public global::G.CreateFineTuningJobRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// A string of up to 18 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? Integrations { get; set; }

        /// <summary>
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}