//HintName: G.Models.WorkflowCustomModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowCustomModel
    {
        /// <summary>
        /// This is the provider of the model (`custom-llm`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowCustomModelProviderJsonConverter))]
        public global::G.WorkflowCustomModelProvider Provider { get; set; }

        /// <summary>
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadataSendMode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowCustomModelMetadataSendModeJsonConverter))]
        public global::G.WorkflowCustomModelMetadataSendMode? MetadataSendMode { get; set; }

        /// <summary>
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCustomModel" /> class.
        /// </summary>
        /// <param name="url">
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </param>
        /// <param name="model">
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`custom-llm`).
        /// </param>
        /// <param name="metadataSendMode">
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </param>
        /// <param name="headers">
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
        public WorkflowCustomModel(
            string url,
            string model,
            global::G.WorkflowCustomModelProvider provider,
            global::G.WorkflowCustomModelMetadataSendMode? metadataSendMode,
            object? headers,
            double? timeoutSeconds,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.MetadataSendMode = metadataSendMode;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.TimeoutSeconds = timeoutSeconds;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCustomModel" /> class.
        /// </summary>
        public WorkflowCustomModel()
        {
        }
    }
}