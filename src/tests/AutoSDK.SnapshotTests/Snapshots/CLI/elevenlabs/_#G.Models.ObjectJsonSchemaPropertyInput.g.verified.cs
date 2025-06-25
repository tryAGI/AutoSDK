//HintName: G.Models.ObjectJsonSchemaPropertyInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectJsonSchemaPropertyInput
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ObjectJsonSchemaPropertyInputTypeJsonConverter))]
        public global::G.ObjectJsonSchemaPropertyInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="required"></param>
        /// <param name="description"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectJsonSchemaPropertyInput(
            global::G.ObjectJsonSchemaPropertyInputType? type,
            global::System.Collections.Generic.IList<string>? required,
            string? description,
            object? properties)
        {
            this.Type = type;
            this.Required = required;
            this.Description = description;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyInput" /> class.
        /// </summary>
        public ObjectJsonSchemaPropertyInput()
        {
        }
    }
}