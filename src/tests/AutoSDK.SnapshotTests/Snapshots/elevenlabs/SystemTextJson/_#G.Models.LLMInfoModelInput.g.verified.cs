//HintName: G.Models.LLMInfoModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"is_checkpoint":false,"llm":"gemini-2.5-flash","max_context_limit":1048576,"max_tokens_limit":8192,"supports_document_input":true,"supports_image_input":true,"supports_parallel_tool_calls":true}
    /// </summary>
    public sealed partial class LLMInfoModelInput
    {
        /// <summary>
        /// The model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LlmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Llm Llm { get; set; }

        /// <summary>
        /// Whether this is a pinned checkpoint version of a model rather than a top-level alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_checkpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCheckpoint { get; set; }

        /// <summary>
        /// Maximum number of output tokens the model can generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokensLimit { get; set; }

        /// <summary>
        /// Maximum number of input context tokens the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxContextLimit { get; set; }

        /// <summary>
        /// Whether the model supports image file inputs during conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_image_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsImageInput { get; set; }

        /// <summary>
        /// Whether the model supports document (PDF) file inputs during conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_document_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsDocumentInput { get; set; }

        /// <summary>
        /// Whether the model supports calling multiple tools in parallel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsParallelToolCalls { get; set; }

        /// <summary>
        /// Available reasoning effort levels for this model. Null if the model does not support configurable reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_reasoning_efforts")]
        public global::System.Collections.Generic.IList<global::G.LLMReasoningEffort>? AvailableReasoningEfforts { get; set; }

        /// <summary>
        /// Deprecation information if this model is deprecated or scheduled for deprecation. Null if the model is not affected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecation_info")]
        public global::G.LLMDeprecationInfoModel? DeprecationInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInfoModelInput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMInfoModelInput(
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
        /// Initializes a new instance of the <see cref="LLMInfoModelInput" /> class.
        /// </summary>
        public LLMInfoModelInput()
        {
        }
    }
}