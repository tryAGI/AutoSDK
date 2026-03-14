//HintName: G.Models.StructuredOutputParser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parses agent output as structured JSON conforming to a specified schema.<br/>
    /// Uses the model's native structured outputs capability to guarantee valid JSON<br/>
    /// that adheres to the provided schema. This is useful when you need the agent's<br/>
    /// final response in a specific format for downstream processing.<br/>
    /// When this parser is configured, the agent emits a StructuredOutputEvent instead<br/>
    /// of AgentOutputEvent. The StructuredOutputEvent contains the validated JSON content<br/>
    /// along with the schema name for identification.<br/>
    /// Note: When using structured outputs, the agent can still use tools normally.<br/>
    /// The schema constraint only applies to the agent's final text response.<br/>
    /// When streaming, the structured output is delivered as a single complete event<br/>
    /// rather than being streamed in chunks.
    /// </summary>
    public sealed partial class StructuredOutputParser
    {
        /// <summary>
        /// The type of output parser, which is always 'structured' for this parser type.<br/>
        /// Default Value: structured<br/>
        /// Example: structured
        /// </summary>
        /// <default>"structured"</default>
        /// <example>structured</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "structured";

        /// <summary>
        /// Specification wrapper for a named JSON schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JsonSchemaSpec JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputParser" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of output parser, which is always 'structured' for this parser type.<br/>
        /// Default Value: structured<br/>
        /// Example: structured
        /// </param>
        /// <param name="jsonSchema">
        /// Specification wrapper for a named JSON schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputParser(
            string type,
            global::G.JsonSchemaSpec jsonSchema)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputParser" /> class.
        /// </summary>
        public StructuredOutputParser()
        {
        }
    }
}