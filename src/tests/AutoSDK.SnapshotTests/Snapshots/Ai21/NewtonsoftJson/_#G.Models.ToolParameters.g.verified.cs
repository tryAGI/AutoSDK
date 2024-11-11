//HintName: G.Models.ToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolParameters
    {
        /// <summary>
        /// Type of the parameter schema, only `object` is supported<br/>
        /// Default Value: object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolParametersType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public object Properties { get; set; } = default!;

        /// <summary>
        /// List of required properties
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameters" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the parameter schema, only `object` is supported<br/>
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required">
        /// List of required properties
        /// </param>
        public ToolParameters(
            object properties,
            global::G.ToolParametersType? type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Type = type;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameters" /> class.
        /// </summary>
        public ToolParameters()
        {
        }
    }
}