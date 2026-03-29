//HintName: G.Models.ToolParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
    /// </summary>
    public sealed partial class ToolParameter
    {
        /// <summary>
        /// Type must be "object" for a JSON Schema object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolParameterTypeJsonConverter))]
        public global::G.ToolParameterType Type { get; set; }

        /// <summary>
        /// The value of properties is an object, where each key is the name of a property and each value is a schema used to validate that property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// List of names of required property when generating this parameter. LLM will do its best to generate the required properties in its function arguments. Property must exist in properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        /// <param name="properties">
        /// The value of properties is an object, where each key is the name of a property and each value is a schema used to validate that property.
        /// </param>
        /// <param name="type">
        /// Type must be "object" for a JSON Schema object.
        /// </param>
        /// <param name="required">
        /// List of names of required property when generating this parameter. LLM will do its best to generate the required properties in its function arguments. Property must exist in properties.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolParameter(
            object properties,
            global::G.ToolParameterType type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        public ToolParameter()
        {
        }
    }
}