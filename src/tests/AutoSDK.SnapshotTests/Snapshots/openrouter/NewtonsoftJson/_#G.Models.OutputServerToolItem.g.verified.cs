//HintName: G.Models.OutputServerToolItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A generic OpenRouter server tool output item
    /// </summary>
    public sealed partial class OutputServerToolItem
    {
        /// <summary>
        /// Server tool type (e.g. openrouter:datetime, openrouter:web_search)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputServerToolItemStatusJsonConverter))]
        public global::G.OutputServerToolItemStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputServerToolItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Server tool type (e.g. openrouter:datetime, openrouter:web_search)
        /// </param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        public OutputServerToolItem(
            string type,
            global::G.OutputServerToolItemStatus status,
            string? id)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputServerToolItem" /> class.
        /// </summary>
        public OutputServerToolItem()
        {
        }
    }
}