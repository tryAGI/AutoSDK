//HintName: G.Models.OutputFileSearchCallItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputFileSearchCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputItemFileSearchCallTypeJsonConverter))]
        public global::G.OutputItemFileSearchCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Queries { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebSearchStatusJsonConverter))]
        public global::G.WebSearchStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFileSearchCallItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="queries"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        public OutputFileSearchCallItem(
            string id,
            global::System.Collections.Generic.IList<string> queries,
            global::G.WebSearchStatus status,
            global::G.OutputItemFileSearchCallType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFileSearchCallItem" /> class.
        /// </summary>
        public OutputFileSearchCallItem()
        {
        }
    }
}