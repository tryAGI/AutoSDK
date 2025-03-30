//HintName: G.Models.QueryParamsJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryParamsJsonSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty> Properties { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="QueryParamsJsonSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        public QueryParamsJsonSchema(
            global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty> properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParamsJsonSchema" /> class.
        /// </summary>
        public QueryParamsJsonSchema()
        {
        }
    }
}