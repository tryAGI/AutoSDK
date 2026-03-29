//HintName: G.Models.DatasetVersionDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionDiff
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_version")]
        public string? FromVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_version")]
        public string? ToVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statistics")]
        public global::G.DatasetVersionDiffStats? Statistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionDiff" /> class.
        /// </summary>
        /// <param name="fromVersion"></param>
        /// <param name="toVersion"></param>
        /// <param name="statistics"></param>
        public DatasetVersionDiff(
            string? fromVersion,
            string? toVersion,
            global::G.DatasetVersionDiffStats? statistics)
        {
            this.FromVersion = fromVersion;
            this.ToVersion = toVersion;
            this.Statistics = statistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionDiff" /> class.
        /// </summary>
        public DatasetVersionDiff()
        {
        }
    }
}