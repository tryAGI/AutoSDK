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
        public string? Type { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_constraints")]
        public global::G.RequiredConstraints? RequiredConstraints { get; set; }

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
        /// <param name="required"></param>
        /// <param name="description"></param>
        /// <param name="properties"></param>
        /// <param name="requiredConstraints"></param>
        public ObjectJsonSchemaPropertyOutput(
            string? type,
            global::System.Collections.Generic.IList<string>? required,
            string? description,
            object? properties,
            global::G.RequiredConstraints? requiredConstraints)
        {
            this.Type = type;
            this.Required = required;
            this.Description = description;
            this.Properties = properties;
            this.RequiredConstraints = requiredConstraints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public ObjectJsonSchemaPropertyOutput()
        {
        }
    }
}