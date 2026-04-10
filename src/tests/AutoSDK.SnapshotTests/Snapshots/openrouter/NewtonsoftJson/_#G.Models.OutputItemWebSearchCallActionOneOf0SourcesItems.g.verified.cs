//HintName: G.Models.OutputItemWebSearchCallActionOneOf0SourcesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemWebSearchCallActionOneOf0SourcesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeJsonConverter))]
        public global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallActionOneOf0SourcesItems" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
        public OutputItemWebSearchCallActionOneOf0SourcesItems(
            string url,
            global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallActionOneOf0SourcesItems" /> class.
        /// </summary>
        public OutputItemWebSearchCallActionOneOf0SourcesItems()
        {
        }
    }
}