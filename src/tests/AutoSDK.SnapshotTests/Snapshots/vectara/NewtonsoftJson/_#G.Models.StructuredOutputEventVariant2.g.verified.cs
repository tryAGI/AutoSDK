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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The name of the JSON schema that the content conforms to.<br/>
        /// Example: order_response
        /// </summary>
        /// <example>order_response</example>
        [global::Newtonsoft.Json.JsonProperty("schema_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SchemaName { get; set; } = default!;

        /// <summary>
        /// The structured JSON content conforming to the output schema.<br/>
        /// Example: {"result":"success","data":{"id":123}}
        /// </summary>
        /// <example>{"result":"success","data":{"id":123}}</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public object Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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