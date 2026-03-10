//HintName: G.Models.LLMListResponseModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"default_deprecation_config":{"fallback_complete_days":7,"fallback_complete_percentage":100,"fallback_start_days":14,"fallback_start_percentage":25,"warning_start_days":30},"llms":[{"is_checkpoint":false,"llm":"gemini-2.5-flash","max_context_limit":1048576,"max_tokens_limit":8192,"supports_document_input":true,"supports_image_input":true,"supports_parallel_tool_calls":true}]}
    /// </summary>
    public sealed partial class LLMListResponseModelOutput
    {
        /// <summary>
        /// List of all available LLM models that can be used with agents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llms", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LLMInfoModelOutput> Llms { get; set; } = default!;

        /// <summary>
        /// The default deprecation timing configuration used for models without a custom override.<br/>
        /// Example: {"fallback_complete_days":7,"fallback_complete_percentage":100,"fallback_start_days":14,"fallback_start_percentage":25,"warning_start_days":30}
        /// </summary>
        /// <example>{"fallback_complete_days":7,"fallback_complete_percentage":100,"fallback_start_days":14,"fallback_start_percentage":25,"warning_start_days":30}</example>
        [global::Newtonsoft.Json.JsonProperty("default_deprecation_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMDeprecationConfigModel DefaultDeprecationConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMListResponseModelOutput" /> class.
        /// </summary>
        /// <param name="llms">
        /// List of all available LLM models that can be used with agents.
        /// </param>
        /// <param name="defaultDeprecationConfig">
        /// The default deprecation timing configuration used for models without a custom override.<br/>
        /// Example: {"fallback_complete_days":7,"fallback_complete_percentage":100,"fallback_start_days":14,"fallback_start_percentage":25,"warning_start_days":30}
        /// </param>
        public LLMListResponseModelOutput(
            global::System.Collections.Generic.IList<global::G.LLMInfoModelOutput> llms,
            global::G.LLMDeprecationConfigModel defaultDeprecationConfig)
        {
            this.Llms = llms ?? throw new global::System.ArgumentNullException(nameof(llms));
            this.DefaultDeprecationConfig = defaultDeprecationConfig ?? throw new global::System.ArgumentNullException(nameof(defaultDeprecationConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMListResponseModelOutput" /> class.
        /// </summary>
        public LLMListResponseModelOutput()
        {
        }
    }
}