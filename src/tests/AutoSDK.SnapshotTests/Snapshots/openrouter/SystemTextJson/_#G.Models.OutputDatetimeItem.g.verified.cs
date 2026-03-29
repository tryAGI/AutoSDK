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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputDatetimeItemTypeJsonConverter))]
        public global::G.OutputDatetimeItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputDatetimeItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OutputDatetimeItemStatus Status { get; set; }

        /// <summary>
        /// ISO 8601 datetime string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Datetime { get; set; }

        /// <summary>
        /// IANA timezone name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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