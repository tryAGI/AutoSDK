//HintName: G.Models.BodyDownloadHistoryItemsV1HistoryDownloadPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDownloadHistoryItemsV1HistoryDownloadPost
    {
        /// <summary>
        /// A list of history items to download, you can get IDs of history items and other metadata using the GET https://api.elevenlabs.io/v1/history endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("history_item_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> HistoryItemIds { get; set; } = default!;

        /// <summary>
        /// Output format to transcode the audio file, can be wav or default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDownloadHistoryItemsV1HistoryDownloadPost" /> class.
        /// </summary>
        /// <param name="historyItemIds">
        /// A list of history items to download, you can get IDs of history items and other metadata using the GET https://api.elevenlabs.io/v1/history endpoint.
        /// </param>
        /// <param name="outputFormat">
        /// Output format to transcode the audio file, can be wav or default.
        /// </param>
        public BodyDownloadHistoryItemsV1HistoryDownloadPost(
            global::System.Collections.Generic.IList<string> historyItemIds,
            string? outputFormat)
        {
            this.HistoryItemIds = historyItemIds ?? throw new global::System.ArgumentNullException(nameof(historyItemIds));
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDownloadHistoryItemsV1HistoryDownloadPost" /> class.
        /// </summary>
        public BodyDownloadHistoryItemsV1HistoryDownloadPost()
        {
        }
    }
}