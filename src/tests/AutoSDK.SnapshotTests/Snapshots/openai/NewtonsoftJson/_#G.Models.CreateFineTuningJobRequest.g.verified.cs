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
        /// [supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </summary>
        /// <example>gpt-4o-mini</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/model-optimization) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.<br/>
        /// This value is now deprecated in favor of `method`, and should be passed in under the `method` parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CreateFineTuningJobRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// A string of up to 64 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/model-optimization) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? Integrations { get; set; }

        /// <summary>
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The method used for fine-tuning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.FineTuneMethod? Method { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequest" /> class.
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
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/model-optimization) for more details.<br/>
        /// Example: file-abc123
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
        /// See the [fine-tuning guide](/docs/guides/model-optimization) for more details.<br/>
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
        /// <param name="method">
        /// The method used for fine-tuning.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public CreateFineTuningJobRequest(
            global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?> model,
            string trainingFile,
            string? suffix,
            string? validationFile,
            global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? integrations,
            int? seed,
            global::G.FineTuneMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Model = model;
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.Suffix = suffix;
            this.ValidationFile = validationFile;
            this.Integrations = integrations;
            this.Seed = seed;
            this.Method = method;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequest" /> class.
        /// </summary>
        public CreateFineTuningJobRequest()
        {
        }
    }
}