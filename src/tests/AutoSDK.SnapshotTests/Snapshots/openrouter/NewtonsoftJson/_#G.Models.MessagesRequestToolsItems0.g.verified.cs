//HintName: G.Models.MessagesRequestToolsItems0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesRequestToolsItemsOneOf0InputSchema InputSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesRequestToolsItemsOneOf0Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesRequestToolsItemsOneOf0CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems0" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputSchema"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl"></param>
        public MessagesRequestToolsItems0(
            string name,
            global::G.MessagesRequestToolsItemsOneOf0InputSchema inputSchema,
            string? description,
            global::G.MessagesRequestToolsItemsOneOf0Type? type,
            global::G.MessagesRequestToolsItemsOneOf0CacheControl? cacheControl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems0" /> class.
        /// </summary>
        public MessagesRequestToolsItems0()
        {
        }
    }
}