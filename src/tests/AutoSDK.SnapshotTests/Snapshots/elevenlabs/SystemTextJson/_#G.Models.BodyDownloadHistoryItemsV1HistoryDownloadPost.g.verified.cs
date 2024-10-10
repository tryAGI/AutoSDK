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
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HistoryItemIds { get; set; }

        /// <summary>
        /// Output format to transcode the audio file, can be wav or default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}