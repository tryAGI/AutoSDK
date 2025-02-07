//HintName: G.Models.CustomProperty.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Custom property defined on an organization
    /// </summary>
    public sealed partial class CustomProperty
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// The URL that can be used to fetch, update, or delete info about this property via the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </summary>
        /// <example>single_select</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomPropertyValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomPropertyValueType ValueType { get; set; }

        /// <summary>
        /// Whether the property is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default value of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? DefaultValue { get; set; }

        /// <summary>
        /// Short description of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_values")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        /// Who can edit the values of the property<br/>
        /// Example: org_actors
        /// </summary>
        /// <example>org_actors</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("values_editable_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomPropertyValuesEditableByJsonConverter))]
        public global::G.CustomPropertyValuesEditableBy? ValuesEditableBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property
        /// </param>
        /// <param name="url">
        /// The URL that can be used to fetch, update, or delete info about this property via the API.
        /// </param>
        /// <param name="valueType">
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </param>
        /// <param name="required">
        /// Whether the property is required.
        /// </param>
        /// <param name="defaultValue">
        /// Default value of the property
        /// </param>
        /// <param name="description">
        /// Short description of the property
        /// </param>
        /// <param name="allowedValues">
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </param>
        /// <param name="valuesEditableBy">
        /// Who can edit the values of the property<br/>
        /// Example: org_actors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomProperty(
            string propertyName,
            global::G.CustomPropertyValueType valueType,
            string? url,
            bool? required,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? defaultValue,
            string? description,
            global::System.Collections.Generic.IList<string>? allowedValues,
            global::G.CustomPropertyValuesEditableBy? valuesEditableBy)
        {
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.ValueType = valueType;
            this.Url = url;
            this.Required = required;
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.AllowedValues = allowedValues;
            this.ValuesEditableBy = valuesEditableBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty" /> class.
        /// </summary>
        public CustomProperty()
        {
        }
    }
}