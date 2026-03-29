//HintName: G.Models.ParametersSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParametersSchema
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.ParameterProperties> Properties { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametersSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="required"></param>
        public ParametersSchema(
            global::System.Collections.Generic.Dictionary<string, global::G.ParameterProperties> properties,
            string? type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametersSchema" /> class.
        /// </summary>
        public ParametersSchema()
        {
        }
    }
}