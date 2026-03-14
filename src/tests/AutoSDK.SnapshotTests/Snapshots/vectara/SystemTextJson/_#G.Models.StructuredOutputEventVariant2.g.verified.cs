//HintName: G.Models.StructuredOutputEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: structured_output
        /// </summary>
        /// <default>"structured_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "structured_output";

        /// <summary>
        /// The name of the JSON schema that the content conforms to.<br/>
        /// Example: order_response
        /// </summary>
        /// <example>order_response</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// The structured JSON content conforming to the output schema.<br/>
        /// Example: {"result":"success","data":{"id":123}}
        /// </summary>
        /// <example>{"result":"success","data":{"id":123}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: structured_output
        /// </param>
        /// <param name="schemaName">
        /// The name of the JSON schema that the content conforms to.<br/>
        /// Example: order_response
        /// </param>
        /// <param name="content">
        /// The structured JSON content conforming to the output schema.<br/>
        /// Example: {"result":"success","data":{"id":123}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputEventVariant2(
            string type,
            string schemaName,
            object content)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputEventVariant2" /> class.
        /// </summary>
        public StructuredOutputEventVariant2()
        {
        }
    }
}