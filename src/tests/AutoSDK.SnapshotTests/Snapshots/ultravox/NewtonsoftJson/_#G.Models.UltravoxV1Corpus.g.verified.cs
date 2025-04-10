//HintName: G.Models.UltravoxV1Corpus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A queryable collection of documents. A corpus can be used to ground Ultravox<br/>
    ///  with factual content for a particular domain.
    /// </summary>
    public sealed partial class UltravoxV1Corpus
    {
        /// <summary>
        /// The unique ID of this corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpusId")]
        public string? CorpusId { get; set; }

        /// <summary>
        /// When this corpus was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The name of this corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of this corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The current stats for this corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::G.UltravoxV1CorpusStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Corpus" /> class.
        /// </summary>
        /// <param name="corpusId">
        /// The unique ID of this corpus.
        /// </param>
        /// <param name="created">
        /// When this corpus was created.
        /// </param>
        /// <param name="name">
        /// The name of this corpus.
        /// </param>
        /// <param name="description">
        /// A description of this corpus.
        /// </param>
        /// <param name="stats">
        /// The current stats for this corpus.
        /// </param>
        public UltravoxV1Corpus(
            string? corpusId,
            global::System.DateTime? created,
            string? name,
            string? description,
            global::G.UltravoxV1CorpusStats? stats)
        {
            this.CorpusId = corpusId;
            this.Created = created;
            this.Name = name;
            this.Description = description;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Corpus" /> class.
        /// </summary>
        public UltravoxV1Corpus()
        {
        }
    }
}