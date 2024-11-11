//HintName: G.Models.OrgsCreateOrUpdateCustomPropertyRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateOrUpdateCustomPropertyRequest
    {
        /// <summary>
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </summary>
        /// <example>single_select</example>
        [global::Newtonsoft.Json.JsonProperty("value_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgsCreateOrUpdateCustomPropertyRequestValueType ValueType { get; set; } = default!;

        /// <summary>
        /// Whether the property is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default value of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? DefaultValue { get; set; }

        /// <summary>
        /// Short description of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_values")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertyRequest" /> class.
        /// </summary>
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
        public OrgsCreateOrUpdateCustomPropertyRequest(
            global::G.OrgsCreateOrUpdateCustomPropertyRequestValueType valueType,
            bool? required,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? defaultValue,
            string? description,
            global::System.Collections.Generic.IList<string>? allowedValues)
        {
            this.ValueType = valueType;
            this.Required = required;
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.AllowedValues = allowedValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertyRequest" /> class.
        /// </summary>
        public OrgsCreateOrUpdateCustomPropertyRequest()
        {
        }
    }
}