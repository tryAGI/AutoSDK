//HintName: G.Models.ListExportRequestsV2ResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListExportRequestsV2ResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_request_id")]
        public string? ExportRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListExportRequestsV2ResponseItemChannelJsonConverter))]
        public global::G.ListExportRequestsV2ResponseItemChannel? Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListExportRequestsV2ResponseItemStatusJsonConverter))]
        public global::G.ListExportRequestsV2ResponseItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp")]
        public int? CreatedTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportRequestsV2ResponseItem" /> class.
        /// </summary>
        /// <param name="exportRequestId"></param>
        /// <param name="channel"></param>
        /// <param name="status"></param>
        /// <param name="url"></param>
        /// <param name="createdTimestamp"></param>
        /// <param name="timezone"></param>
        public ListExportRequestsV2ResponseItem(
            string? exportRequestId,
            global::G.ListExportRequestsV2ResponseItemChannel? channel,
            global::G.ListExportRequestsV2ResponseItemStatus? status,
            string? url,
            int? createdTimestamp,
            string? timezone)
        {
            this.ExportRequestId = exportRequestId;
            this.Channel = channel;
            this.Status = status;
            this.Url = url;
            this.CreatedTimestamp = createdTimestamp;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportRequestsV2ResponseItem" /> class.
        /// </summary>
        public ListExportRequestsV2ResponseItem()
        {
        }
    }
}