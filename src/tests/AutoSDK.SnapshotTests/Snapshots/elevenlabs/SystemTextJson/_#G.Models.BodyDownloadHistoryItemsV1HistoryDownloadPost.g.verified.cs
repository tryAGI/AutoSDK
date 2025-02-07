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

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDownloadHistoryItemsV1HistoryDownloadPost" /> class.
        /// </summary>
        /// <param name="historyItemIds">
        /// A list of history items to download, you can get IDs of history items and other metadata using the GET https://api.elevenlabs.io/v1/history endpoint.
        /// </param>
        /// <param name="outputFormat">
        /// Output format to transcode the audio file, can be wav or default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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