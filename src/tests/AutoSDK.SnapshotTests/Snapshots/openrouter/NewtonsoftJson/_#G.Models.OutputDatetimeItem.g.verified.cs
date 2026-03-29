//HintName: G.Models.OutputDatetimeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An openrouter:datetime server tool output item
    /// </summary>
    public sealed partial class OutputDatetimeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputDatetimeItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputDatetimeItemStatus Status { get; set; } = default!;

        /// <summary>
        /// ISO 8601 datetime string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datetime", Required = global::Newtonsoft.Json.Required.Always)]
        public string Datetime { get; set; } = default!;

        /// <summary>
        /// IANA timezone name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timezone { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputDatetimeItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="datetime">
        /// ISO 8601 datetime string
        /// </param>
        /// <param name="timezone">
        /// IANA timezone name
        /// </param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        public OutputDatetimeItem(
            global::G.OutputDatetimeItemStatus status,
            string datetime,
            string timezone,
            global::G.OutputDatetimeItemType type,
            string? id)
        {
            this.Type = type;
            this.Id = id;
            this.Status = status;
            this.Datetime = datetime ?? throw new global::System.ArgumentNullException(nameof(datetime));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputDatetimeItem" /> class.
        /// </summary>
        public OutputDatetimeItem()
        {
        }
    }
}