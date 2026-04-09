//HintName: G.Models.Llm.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A LLM can be used to enhance query results with a response, and be used as the responder during a chat.
    /// </summary>
    public sealed partial class Llm
    {
        /// <summary>
        /// The ID of the LLM.<br/>
        /// Example: llm_1021844
        /// </summary>
        /// <example>llm_1021844</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the LLM.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </summary>
        /// <example>Claude 3.7 Sonnet</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model.
        /// </summary>
        /// <example>The Anthropic Claude 3.7 Sonnet model.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the LLM is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Capabilities of a Large Language Model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities")]
        public global::G.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
        /// Example: platform
        /// </summary>
        /// <example>platform</example>
        [global::Newtonsoft.Json.JsonProperty("ownership")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMOwnershipJsonConverter))]
        public global::G.LLMOwnership? Ownership { get; set; }

        /// <summary>
        /// List of prompts that the model can use. This is deprecated; see `/v2/generation_presets` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.Prompt>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the LLM.<br/>
        /// Example: llm_1021844
        /// </param>
        /// <param name="name">
        /// Name of the LLM.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </param>
        /// <param name="description">
        /// The description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the LLM is enabled.
        /// </param>
        /// <param name="default">
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
        /// <param name="ownership">
        /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
        /// Example: platform
        /// </param>
        public Llm(
            string? id,
            string? name,
            string? description,
            bool? enabled,
            bool? @default,
            global::G.LLMCapabilities? capabilities,
            global::G.LLMOwnership? ownership)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Default = @default;
            this.Capabilities = capabilities;
            this.Ownership = ownership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        public Llm()
        {
        }
    }
}