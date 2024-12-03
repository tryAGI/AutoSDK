//HintName: G.Models.DatasetIndexInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class DatasetIndexInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_version")]
        public global::System.DateTime? LastUpdatedVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIndexInfo" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        /// <param name="lastUpdatedVersion"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetIndexInfo(
            global::System.Guid datasetId,
            string? tag,
            global::System.DateTime? lastUpdatedVersion)
        {
            this.DatasetId = datasetId;
            this.Tag = tag;
            this.LastUpdatedVersion = lastUpdatedVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIndexInfo" /> class.
        /// </summary>
        public DatasetIndexInfo()
        {
        }
    }
}