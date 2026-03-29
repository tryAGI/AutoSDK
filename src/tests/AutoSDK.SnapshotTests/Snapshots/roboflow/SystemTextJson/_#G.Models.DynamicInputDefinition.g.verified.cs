//HintName: G.Models.DynamicInputDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicInputDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"DynamicInputDefinition"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "DynamicInputDefinition";

        /// <summary>
        /// Flag to decide if default value is provided for input<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_default_value")]
        public bool? HasDefaultValue { get; set; }

        /// <summary>
        /// Definition of default value for a field. Use in combination with, `has_default_value` to decide on default value if field is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public object? DefaultValue { get; set; }

        /// <summary>
        /// Flag deciding if `default_value` will be added for manifest field annotation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_optional")]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Flag deciding if declared property holds dimensionality reference - see how dimensionality works for statically defined blocks to discover meaning of the parameter.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dimensionality_reference")]
        public bool? IsDimensionalityReference { get; set; }

        /// <summary>
        /// Accepted dimensionality offset for parameter. Dimensionality works the same as for traditional workflows blocks.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensionality_offset")]
        public int? DimensionalityOffset { get; set; }

        /// <summary>
        /// Union of selector types accepted by input. Should be empty if field does not accept selectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector_types")]
        public global::System.Collections.Generic.IList<global::G.SelectorType>? SelectorTypes { get; set; }

        /// <summary>
        /// Mapping of `selector_types` into names of kinds to be compatible. Empty dict (default value) means wildcard kind for all selectors. If name of kind given - must be valid kind, known for workflow execution engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector_data_kind")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? SelectorDataKind { get; set; }

        /// <summary>
        /// List of types representing union of types for static values (non selectors) that shall be accepted for input field. Empty list represents no value types allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_types")]
        public global::System.Collections.Generic.IList<global::G.ValueType>? ValueTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicInputDefinition" /> class.
        /// </summary>
        /// <param name="hasDefaultValue">
        /// Flag to decide if default value is provided for input<br/>
        /// Default Value: false
        /// </param>
        /// <param name="defaultValue">
        /// Definition of default value for a field. Use in combination with, `has_default_value` to decide on default value if field is optional.
        /// </param>
        /// <param name="isOptional">
        /// Flag deciding if `default_value` will be added for manifest field annotation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isDimensionalityReference">
        /// Flag deciding if declared property holds dimensionality reference - see how dimensionality works for statically defined blocks to discover meaning of the parameter.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dimensionalityOffset">
        /// Accepted dimensionality offset for parameter. Dimensionality works the same as for traditional workflows blocks.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="selectorTypes">
        /// Union of selector types accepted by input. Should be empty if field does not accept selectors.
        /// </param>
        /// <param name="selectorDataKind">
        /// Mapping of `selector_types` into names of kinds to be compatible. Empty dict (default value) means wildcard kind for all selectors. If name of kind given - must be valid kind, known for workflow execution engine.
        /// </param>
        /// <param name="valueTypes">
        /// List of types representing union of types for static values (non selectors) that shall be accepted for input field. Empty list represents no value types allowed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicInputDefinition(
            bool? hasDefaultValue,
            object? defaultValue,
            bool? isOptional,
            bool? isDimensionalityReference,
            int? dimensionalityOffset,
            global::System.Collections.Generic.IList<global::G.SelectorType>? selectorTypes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? selectorDataKind,
            global::System.Collections.Generic.IList<global::G.ValueType>? valueTypes,
            string type = "DynamicInputDefinition")
        {
            this.Type = type;
            this.HasDefaultValue = hasDefaultValue;
            this.DefaultValue = defaultValue;
            this.IsOptional = isOptional;
            this.IsDimensionalityReference = isDimensionalityReference;
            this.DimensionalityOffset = dimensionalityOffset;
            this.SelectorTypes = selectorTypes;
            this.SelectorDataKind = selectorDataKind;
            this.ValueTypes = valueTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicInputDefinition" /> class.
        /// </summary>
        public DynamicInputDefinition()
        {
        }
    }
}