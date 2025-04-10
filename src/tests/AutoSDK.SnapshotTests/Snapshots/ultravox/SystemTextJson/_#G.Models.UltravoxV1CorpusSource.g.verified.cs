//HintName: G.Models.UltravoxV1CorpusSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A source of documents for building a corpus. A source defines where documents<br/>
    ///  are pulled from.
    /// </summary>
    public sealed partial class UltravoxV1CorpusSource
    {
        /// <summary>
        /// The id of this source's corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpusId")]
        public string? CorpusId { get; set; }

        /// <summary>
        /// The unique ID of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        public string? SourceId { get; set; }

        /// <summary>
        /// When this source was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The name of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The current stats for this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::G.UltravoxV1SourceStats? Stats { get; set; }

        /// <summary>
        /// DEPRECATED. Prefer setting crawl instead. If either crawl or upload is set, this field will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loadSpec")]
        public global::G.UltravoxV1CrawlSpec? LoadSpec { get; set; }

        /// <summary>
        /// Allows loading documents by crawling the web.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl")]
        public global::G.UltravoxV1CrawlSpec? Crawl { get; set; }

        /// <summary>
        /// Allows loading from a uploaded document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload")]
        public global::G.UltravoxV1UploadSpec? Upload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusSource" /> class.
        /// </summary>
        /// <param name="corpusId">
        /// The id of this source's corpus.
        /// </param>
        /// <param name="sourceId">
        /// The unique ID of this source.
        /// </param>
        /// <param name="created">
        /// When this source was created.
        /// </param>
        /// <param name="name">
        /// The name of this source.
        /// </param>
        /// <param name="description">
        /// A description of this source.
        /// </param>
        /// <param name="stats">
        /// The current stats for this source.
        /// </param>
        /// <param name="loadSpec">
        /// DEPRECATED. Prefer setting crawl instead. If either crawl or upload is set, this field will be ignored.
        /// </param>
        /// <param name="crawl">
        /// Allows loading documents by crawling the web.
        /// </param>
        /// <param name="upload">
        /// Allows loading from a uploaded document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusSource(
            string? corpusId,
            string? sourceId,
            global::System.DateTime? created,
            string? name,
            string? description,
            global::G.UltravoxV1SourceStats? stats,
            global::G.UltravoxV1CrawlSpec? loadSpec,
            global::G.UltravoxV1CrawlSpec? crawl,
            global::G.UltravoxV1UploadSpec? upload)
        {
            this.CorpusId = corpusId;
            this.SourceId = sourceId;
            this.Created = created;
            this.Name = name;
            this.Description = description;
            this.Stats = stats;
            this.LoadSpec = loadSpec;
            this.Crawl = crawl;
            this.Upload = upload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusSource" /> class.
        /// </summary>
        public UltravoxV1CorpusSource()
        {
        }
    }
}