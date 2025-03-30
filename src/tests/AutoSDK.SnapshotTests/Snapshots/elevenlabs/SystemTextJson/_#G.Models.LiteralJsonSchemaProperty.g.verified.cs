//HintName: G.Models.LiteralJsonSchemaProperty.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
        /// The description of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The dynamic variable of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// The constant value of the property
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
        /// The description of the property
        /// </param>
        /// <param name="dynamicVariable">
        /// The dynamic variable of the property
        /// </param>
        /// <param name="constantValue">
        /// The constant value of the property
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteralJsonSchemaProperty(
            global::G.LiteralJsonSchemaPropertyType type,
            string? description,
            string? dynamicVariable,
            global::G.AnyOf<string, int?, double?, bool?>? constantValue)
        {
            this.Type = type;
            this.Description = description;
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