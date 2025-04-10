//HintName: G.Models.UltravoxV1SourceStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current stats for a source.
    /// </summary>
    public sealed partial class UltravoxV1SourceStats
    {
        /// <summary>
        /// The current status of this source, indicating whether it affects queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.UltravoxV1SourceStatsStatus? Status { get; set; }

        /// <summary>
        /// When this source last finished contributing contents to its corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdated")]
        public global::System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The number of documents in this source. This includes both loaded documents<br/>
        ///  and derived documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numDocs")]
        public int? NumDocs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SourceStats" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of this source, indicating whether it affects queries.
        /// </param>
        /// <param name="lastUpdated">
        /// When this source last finished contributing contents to its corpus.
        /// </param>
        /// <param name="numDocs">
        /// The number of documents in this source. This includes both loaded documents<br/>
        ///  and derived documents.
        /// </param>
        public UltravoxV1SourceStats(
            global::G.UltravoxV1SourceStatsStatus? status,
            global::System.DateTime? lastUpdated,
            int? numDocs)
        {
            this.Status = status;
            this.LastUpdated = lastUpdated;
            this.NumDocs = numDocs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SourceStats" /> class.
        /// </summary>
        public UltravoxV1SourceStats()
        {
        }
    }
}