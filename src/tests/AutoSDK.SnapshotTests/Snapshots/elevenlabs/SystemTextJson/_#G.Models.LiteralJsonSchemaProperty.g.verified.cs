//HintName: G.Models.LiteralJsonSchemaProperty.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema property for literal JSON types. IMPORTANT: Only ONE of the following fields can be set: description (LLM provides value), dynamic_variable (value from variable), is_system_provided (system provides value), or constant_value (fixed value). These are mutually exclusive.<br/>
    /// Example: {"description":"A user-provided message","type":"string"}
    /// </summary>
    public sealed partial class LiteralJsonSchemaProperty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LiteralJsonSchemaPropertyType Type { get; set; }

        /// <summary>
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, and constant_value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of allowed string values for string type parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_system_provided")]
        public bool? IsSystemProvided { get; set; }

        /// <summary>
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, and constant_value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, and is_system_provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>))]
        public global::G.AnyOf<string, int?, double?, bool?>? ConstantValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralJsonSchemaProperty" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, and constant_value.
        /// </param>
        /// <param name="enum">
        /// List of allowed string values for string type parameters
        /// </param>
        /// <param name="isSystemProvided">
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariable">
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, and constant_value.
        /// </param>
        /// <param name="constantValue">
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, and is_system_provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteralJsonSchemaProperty(
            global::G.LiteralJsonSchemaPropertyType type,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            bool? isSystemProvided,
            string? dynamicVariable,
            global::G.AnyOf<string, int?, double?, bool?>? constantValue)
        {
            this.Type = type;
            this.Description = description;
            this.Enum = @enum;
            this.IsSystemProvided = isSystemProvided;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralJsonSchemaProperty" /> class.
        /// </summary>
        public LiteralJsonSchemaProperty()
        {
        }
    }
}