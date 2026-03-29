//HintName: G.Models.DatasetVersionSummaryPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of the latest dataset version<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DatasetVersionSummaryPublic
    {
        /// <summary>
        /// Unique identifier of the version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Hash of the version content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_hash")]
        public string? VersionHash { get; set; }

        /// <summary>
        /// Sequential version name formatted as 'v1', 'v2', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_name")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Description of changes in this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// Tags associated with this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionSummaryPublic" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the version
        /// </param>
        /// <param name="versionHash">
        /// Hash of the version content
        /// </param>
        /// <param name="versionName">
        /// Sequential version name formatted as 'v1', 'v2', etc.
        /// </param>
        /// <param name="changeDescription">
        /// Description of changes in this version
        /// </param>
        /// <param name="tags">
        /// Tags associated with this version
        /// </param>
        public DatasetVersionSummaryPublic(
            global::System.Guid? id,
            string? versionHash,
            string? versionName,
            string? changeDescription,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id;
            this.VersionHash = versionHash;
            this.VersionName = versionName;
            this.ChangeDescription = changeDescription;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionSummaryPublic" /> class.
        /// </summary>
        public DatasetVersionSummaryPublic()
        {
        }
    }
}