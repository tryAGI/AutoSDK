//HintName: G.Models.LLMCapabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Capabilities of a Large Language Model.
    /// </summary>
    public sealed partial class LLMCapabilities
    {
        /// <summary>
        /// Whether the model supports image inputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_support")]
        public bool? ImageSupport { get; set; }

        /// <summary>
        /// Maximum context window size in tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_limit")]
        public int? ContextLimit { get; set; }

        /// <summary>
        /// Whether the model supports tool/function calling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calling")]
        public bool? ToolCalling { get; set; }

        /// <summary>
        /// Whether the model supports structured output generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structured_outputs")]
        public bool? StructuredOutputs { get; set; }

        /// <summary>
        /// Whether the model requires strict role alternation in conversations. When true, consecutive messages of the same role will be grouped together.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_role_alternation")]
        public bool? RequiresRoleAlternation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCapabilities" /> class.
        /// </summary>
        /// <param name="imageSupport">
        /// Whether the model supports image inputs.
        /// </param>
        /// <param name="contextLimit">
        /// Maximum context window size in tokens.
        /// </param>
        /// <param name="toolCalling">
        /// Whether the model supports tool/function calling.
        /// </param>
        /// <param name="structuredOutputs">
        /// Whether the model supports structured output generation.
        /// </param>
        /// <param name="requiresRoleAlternation">
        /// Whether the model requires strict role alternation in conversations. When true, consecutive messages of the same role will be grouped together.
        /// </param>
        public LLMCapabilities(
            bool? imageSupport,
            int? contextLimit,
            bool? toolCalling,
            bool? structuredOutputs,
            bool? requiresRoleAlternation)
        {
            this.ImageSupport = imageSupport;
            this.ContextLimit = contextLimit;
            this.ToolCalling = toolCalling;
            this.StructuredOutputs = structuredOutputs;
            this.RequiresRoleAlternation = requiresRoleAlternation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCapabilities" /> class.
        /// </summary>
        public LLMCapabilities()
        {
        }
    }
}