//HintName: G.Models.BetaTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaToolTypeJsonConverter))]
        public global::G.BetaToolType? Type { get; set; }

        /// <summary>
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that the model has about what the tool is and how to use it, the better it will perform. You can use natural language descriptions to reinforce important aspects of the tool input JSON schema.<br/>
        /// Example: Get the current weather in a given location
        /// </summary>
        /// <example>Get the current weather in a given location</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model will produce.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BetaInputSchema InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that the model has about what the tool is and how to use it, the better it will perform. You can use natural language descriptions to reinforce important aspects of the tool input JSON schema.<br/>
        /// Example: Get the current weather in a given location
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
        /// <param name="inputSchema">
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model will produce.
        /// </param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTool(
            string name,
            global::G.BetaInputSchema inputSchema,
            global::G.BetaToolType? type,
            string? description,
            global::G.BetaCacheControlEphemeral? cacheControl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Type = type;
            this.Description = description;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTool" /> class.
        /// </summary>
        public BetaTool()
        {
        }
    }
}