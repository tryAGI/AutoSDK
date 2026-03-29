//HintName: G.Models.RetellLLMResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetellLLMResponseVariant1
    {
        /// <summary>
        /// Unique id of Retell LLM Response Engine.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmId { get; set; }

        /// <summary>
        /// Version of the Retell LLM Response Engine.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Whether the Retell LLM Response Engine is published.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLLMResponseVariant1" /> class.
        /// </summary>
        /// <param name="llmId">
        /// Unique id of Retell LLM Response Engine.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Version of the Retell LLM Response Engine.<br/>
        /// Example: 0
        /// </param>
        /// <param name="isPublished">
        /// Whether the Retell LLM Response Engine is published.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetellLLMResponseVariant1(
            string llmId,
            int? version,
            bool? isPublished)
        {
            this.LlmId = llmId ?? throw new global::System.ArgumentNullException(nameof(llmId));
            this.Version = version;
            this.IsPublished = isPublished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLLMResponseVariant1" /> class.
        /// </summary>
        public RetellLLMResponseVariant1()
        {
        }
    }
}