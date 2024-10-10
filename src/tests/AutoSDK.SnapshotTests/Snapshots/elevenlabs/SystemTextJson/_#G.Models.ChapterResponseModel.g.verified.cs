//HintName: G.Models.ChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastConversionDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_block_conversion_unix_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastBlockConversionUnixMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversion_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConversionProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeDownloaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChapterResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterStatisticsResponseModel Statistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}