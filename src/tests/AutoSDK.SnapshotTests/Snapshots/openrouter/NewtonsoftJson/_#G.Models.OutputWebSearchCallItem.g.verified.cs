//HintName: G.Models.OutputWebSearchCallItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputWebSearchCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputItemWebSearchCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputItemWebSearchCallAction Action { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebSearchStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchCallItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        public OutputWebSearchCallItem(
            string id,
            global::G.OutputItemWebSearchCallAction action,
            global::G.WebSearchStatus status,
            global::G.OutputItemWebSearchCallType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Action = action;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchCallItem" /> class.
        /// </summary>
        public OutputWebSearchCallItem()
        {
        }
    }
}