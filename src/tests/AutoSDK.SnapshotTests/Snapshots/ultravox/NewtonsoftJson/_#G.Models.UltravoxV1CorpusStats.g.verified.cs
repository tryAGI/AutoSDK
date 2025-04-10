//HintName: G.Models.UltravoxV1CorpusStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current stats for a corpus. This gives an indication of whether the<br/>
    ///  corpus is queryable and what sorts of results can be expected.
    /// </summary>
    public sealed partial class UltravoxV1CorpusStats
    {
        /// <summary>
        /// The current status of this corpus, indicating whether it is queryable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.UltravoxV1CorpusStatsStatus? Status { get; set; }

        /// <summary>
        /// The last time the contents of this corpus were updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdated")]
        public global::System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The number of chunks in this corpus. Chunks are subsets of documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numChunks")]
        public int? NumChunks { get; set; }

        /// <summary>
        /// The number of documents in this corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numDocs")]
        public int? NumDocs { get; set; }

        /// <summary>
        /// The number of vectors in this corpus. Vectors are used for semantic search.<br/>
        ///  Multiple vectors may correspond to a single chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numVectors")]
        public int? NumVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusStats" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of this corpus, indicating whether it is queryable.
        /// </param>
        /// <param name="lastUpdated">
        /// The last time the contents of this corpus were updated.
        /// </param>
        /// <param name="numChunks">
        /// The number of chunks in this corpus. Chunks are subsets of documents.
        /// </param>
        /// <param name="numDocs">
        /// The number of documents in this corpus.
        /// </param>
        /// <param name="numVectors">
        /// The number of vectors in this corpus. Vectors are used for semantic search.<br/>
        ///  Multiple vectors may correspond to a single chunk.
        /// </param>
        public UltravoxV1CorpusStats(
            global::G.UltravoxV1CorpusStatsStatus? status,
            global::System.DateTime? lastUpdated,
            int? numChunks,
            int? numDocs,
            int? numVectors)
        {
            this.Status = status;
            this.LastUpdated = lastUpdated;
            this.NumChunks = numChunks;
            this.NumDocs = numDocs;
            this.NumVectors = numVectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusStats" /> class.
        /// </summary>
        public UltravoxV1CorpusStats()
        {
        }
    }
}