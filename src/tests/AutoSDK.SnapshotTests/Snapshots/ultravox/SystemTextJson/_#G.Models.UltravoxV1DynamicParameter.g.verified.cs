//HintName: G.Models.UltravoxV1DynamicParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dynamic parameter the tool accepts that may be set by the model.
    /// </summary>
    public sealed partial class UltravoxV1DynamicParameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Where the parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UltravoxV1DynamicParameterLocationJsonConverter))]
        public global::G.UltravoxV1DynamicParameterLocation? Location { get; set; }

        /// <summary>
        /// The JsonSchema definition of the parameter. This typically<br/>
        ///  includes things like type, description, enum values, format,<br/>
        ///  other restrictions, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Whether the parameter is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DynamicParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter.
        /// </param>
        /// <param name="location">
        /// Where the parameter is used.
        /// </param>
        /// <param name="schema">
        /// The JsonSchema definition of the parameter. This typically<br/>
        ///  includes things like type, description, enum values, format,<br/>
        ///  other restrictions, etc.
        /// </param>
        /// <param name="required">
        /// Whether the parameter is required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1DynamicParameter(
            string? name,
            global::G.UltravoxV1DynamicParameterLocation? location,
            object? schema,
            bool? required)
        {
            this.Name = name;
            this.Location = location;
            this.Schema = schema;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DynamicParameter" /> class.
        /// </summary>
        public UltravoxV1DynamicParameter()
        {
        }
    }
}