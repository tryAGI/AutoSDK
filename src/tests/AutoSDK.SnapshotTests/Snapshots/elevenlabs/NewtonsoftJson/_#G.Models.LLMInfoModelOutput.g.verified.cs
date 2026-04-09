//HintName: G.Models.LLMInfoModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"is_checkpoint":false,"llm":"gemini-2.5-flash","max_context_limit":1048576,"max_tokens_limit":8192,"supports_document_input":true,"supports_image_input":true,"supports_parallel_tool_calls":true}
    /// </summary>
    public sealed partial class LLMInfoModelOutput
    {
        /// <summary>
        /// The model identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LlmJsonConverter))]
        public global::G.Llm Llm { get; set; } = default!;

        /// <summary>
        /// Whether this is a pinned checkpoint version of a model rather than a top-level alias.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_checkpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCheckpoint { get; set; } = default!;

        /// <summary>
        /// Maximum number of output tokens the model can generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxTokensLimit { get; set; } = default!;

        /// <summary>
        /// Maximum number of input context tokens the model supports.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_context_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxContextLimit { get; set; } = default!;

        /// <summary>
        /// Whether the model supports image file inputs during conversations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_image_input", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SupportsImageInput { get; set; } = default!;

        /// <summary>
        /// Whether the model supports document (PDF) file inputs during conversations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_document_input", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SupportsDocumentInput { get; set; } = default!;

        /// <summary>
        /// Whether the model supports calling multiple tools in parallel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_parallel_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SupportsParallelToolCalls { get; set; } = default!;

        /// <summary>
        /// Available reasoning effort levels for this model. Null if the model does not support configurable reasoning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("available_reasoning_efforts")]
        public global::System.Collections.Generic.IList<global::G.LLMReasoningEffort>? AvailableReasoningEfforts { get; set; }

        /// <summary>
        /// Deprecation information if this model is deprecated or scheduled for deprecation. Null if the model is not affected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation_info")]
        public global::G.LLMDeprecationInfoModel? DeprecationInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInfoModelOutput" /> class.
        /// </summary>
        /// <param name="llm">
        /// The model identifier.
        /// </param>
        /// <param name="isCheckpoint">
        /// Whether this is a pinned checkpoint version of a model rather than a top-level alias.
        /// </param>
        /// <param name="maxTokensLimit">
        /// Maximum number of output tokens the model can generate.
        /// </param>
        /// <param name="maxContextLimit">
        /// Maximum number of input context tokens the model supports.
        /// </param>
        /// <param name="supportsImageInput">
        /// Whether the model supports image file inputs during conversations.
        /// </param>
        /// <param name="supportsDocumentInput">
        /// Whether the model supports document (PDF) file inputs during conversations.
        /// </param>
        /// <param name="supportsParallelToolCalls">
        /// Whether the model supports calling multiple tools in parallel.
        /// </param>
        /// <param name="availableReasoningEfforts">
        /// Available reasoning effort levels for this model. Null if the model does not support configurable reasoning.
        /// </param>
        /// <param name="deprecationInfo">
        /// Deprecation information if this model is deprecated or scheduled for deprecation. Null if the model is not affected.
        /// </param>
        public LLMInfoModelOutput(
            global::G.Llm llm,
            bool isCheckpoint,
            int maxTokensLimit,
            int maxContextLimit,
            bool supportsImageInput,
            bool supportsDocumentInput,
            bool supportsParallelToolCalls,
            global::System.Collections.Generic.IList<global::G.LLMReasoningEffort>? availableReasoningEfforts,
            global::G.LLMDeprecationInfoModel? deprecationInfo)
        {
            this.Llm = llm;
            this.IsCheckpoint = isCheckpoint;
            this.MaxTokensLimit = maxTokensLimit;
            this.MaxContextLimit = maxContextLimit;
            this.SupportsImageInput = supportsImageInput;
            this.SupportsDocumentInput = supportsDocumentInput;
            this.SupportsParallelToolCalls = supportsParallelToolCalls;
            this.AvailableReasoningEfforts = availableReasoningEfforts;
            this.DeprecationInfo = deprecationInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInfoModelOutput" /> class.
        /// </summary>
        public LLMInfoModelOutput()
        {
        }
    }
}