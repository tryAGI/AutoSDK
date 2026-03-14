//HintName: G.Models.JsonSchemaDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A JSON Schema definition for specifying data structure. Supports recursive schemas for nested objects.
    /// </summary>
    public sealed partial class JsonSchemaDefinition
    {
        /// <summary>
        /// The JSON type for this schema element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonSchemaDefinitionType Type { get; set; } = default!;

        /// <summary>
        /// Property definitions when type is 'object'. Each key maps to a nested JsonSchemaDefinition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.JsonSchemaDefinition>? Properties { get; set; }

        /// <summary>
        /// List of required property names when type is 'object'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Whether to allow additional properties beyond those defined.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// A JSON Schema definition for specifying data structure. Supports recursive schemas for nested objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::G.JsonSchemaDefinition? Items { get; set; }

        /// <summary>
        /// Allowed values for this schema element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enum")]
        public byte[]? Enum { get; set; }

        /// <summary>
        /// Human-readable description of this schema element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaDefinition" /> class.
        /// </summary>
        /// <param name="type">
        /// The JSON type for this schema element.
        /// </param>
        /// <param name="properties">
        /// Property definitions when type is 'object'. Each key maps to a nested JsonSchemaDefinition.
        /// </param>
        /// <param name="required">
        /// List of required property names when type is 'object'.
        /// </param>
        /// <param name="additionalProperties">
        /// Whether to allow additional properties beyond those defined.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="items">
        /// A JSON Schema definition for specifying data structure. Supports recursive schemas for nested objects.
        /// </param>
        /// <param name="enum">
        /// Allowed values for this schema element.
        /// </param>
        /// <param name="description">
        /// Human-readable description of this schema element.
        /// </param>
        public JsonSchemaDefinition(
            global::G.JsonSchemaDefinitionType type,
            global::System.Collections.Generic.Dictionary<string, global::G.JsonSchemaDefinition>? properties,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties,
            global::G.JsonSchemaDefinition? items,
            byte[]? @enum,
            string? description)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
            this.Items = items;
            this.Enum = @enum;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaDefinition" /> class.
        /// </summary>
        public JsonSchemaDefinition()
        {
        }
    }
}