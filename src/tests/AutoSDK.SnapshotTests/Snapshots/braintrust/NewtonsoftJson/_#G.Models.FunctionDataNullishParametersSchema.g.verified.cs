//HintName: G.Models.FunctionDataNullishParametersSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema format for parameters
    /// </summary>
    public sealed partial class FunctionDataNullishParametersSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter))]
        public global::G.FunctionDataNullishParametersSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object?>> Properties { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishParametersSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="type"></param>
        /// <param name="required"></param>
        /// <param name="additionalProperties"></param>
        public FunctionDataNullishParametersSchema(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object?>> properties,
            global::G.FunctionDataNullishParametersSchemaType type,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishParametersSchema" /> class.
        /// </summary>
        public FunctionDataNullishParametersSchema()
        {
        }
    }
}