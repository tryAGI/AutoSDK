//HintName: G.Models.DatasetEntityMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetEntityMetadata
    {
        /// <summary>
        /// Whether the dataset group only has draft versions (no published versions).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDraft")]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// The latest published version number of the dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_number")]
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEntityMetadata" /> class.
        /// </summary>
        /// <param name="isDraft">
        /// Whether the dataset group only has draft versions (no published versions).
        /// </param>
        /// <param name="latestVersionNumber">
        /// The latest published version number of the dataset.
        /// </param>
        public DatasetEntityMetadata(
            bool? isDraft,
            int? latestVersionNumber)
        {
            this.IsDraft = isDraft;
            this.LatestVersionNumber = latestVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEntityMetadata" /> class.
        /// </summary>
        public DatasetEntityMetadata()
        {
        }
    }
}