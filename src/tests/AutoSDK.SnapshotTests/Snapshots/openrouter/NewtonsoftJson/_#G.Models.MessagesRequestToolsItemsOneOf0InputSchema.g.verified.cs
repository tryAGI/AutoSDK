//HintName: G.Models.MessagesRequestToolsItemsOneOf0InputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf0InputSchema
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0InputSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        public MessagesRequestToolsItemsOneOf0InputSchema(
            string? type,
            object? properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0InputSchema" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf0InputSchema()
        {
        }
    }
}