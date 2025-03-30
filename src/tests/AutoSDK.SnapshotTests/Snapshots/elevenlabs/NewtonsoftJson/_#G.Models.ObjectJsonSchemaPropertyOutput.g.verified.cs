//HintName: G.Models.ObjectJsonSchemaPropertyOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectJsonSchemaPropertyOutput
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ObjectJsonSchemaPropertyOutputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="description"></param>
        public ObjectJsonSchemaPropertyOutput(
            global::G.ObjectJsonSchemaPropertyOutputType? type,
            object? properties,
            global::System.Collections.Generic.IList<string>? required,
            string? description)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public ObjectJsonSchemaPropertyOutput()
        {
        }
    }
}