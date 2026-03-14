//HintName: G.Models.AgentKeyedSearchCorpus.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Agent-specific keyed search corpus that supports eager references for corpus_key and metadata_filter.
    /// </summary>
    public sealed partial class AgentKeyedSearchCorpus
    {
        /// <summary>
        /// The corpus to search. Can be either a static string (e.g. "my-corpus") or an EagerReference object (e.g. {"$ref": "session.metadata.corpus"}). When an EagerReference is provided, the $ref path is resolved from the session context at the start of each turn, before LLM processing begins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::G.EagerReference> CorpusKey { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The filter to narrow search results. Can be either a static string (e.g. "doc.department = 'engineering'") or an EagerReference object (e.g. {"$ref": "session.metadata.filters.user"}). When an EagerReference is provided, the $ref path is resolved from the session context at the start of each turn, before LLM processing begins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_filter")]
        public global::G.OneOf<string, global::G.EagerReference>? MetadataFilter { get; set; }

        /// <summary>
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Default Value: 0.025
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lexical_interpolation")]
        public float? LexicalInterpolation { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("semantics")]
        public global::G.SearchSemantics? Semantics { get; set; }

        /// <summary>
        /// Query override for this specific corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeyedSearchCorpus" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// The corpus to search. Can be either a static string (e.g. "my-corpus") or an EagerReference object (e.g. {"$ref": "session.metadata.corpus"}). When an EagerReference is provided, the $ref path is resolved from the session context at the start of each turn, before LLM processing begins.
        /// </param>
        /// <param name="customDimensions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadataFilter">
        /// The filter to narrow search results. Can be either a static string (e.g. "doc.department = 'engineering'") or an EagerReference object (e.g. {"$ref": "session.metadata.filters.user"}). When an EagerReference is provided, the $ref path is resolved from the session context at the start of each turn, before LLM processing begins.
        /// </param>
        /// <param name="lexicalInterpolation">
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Default Value: 0.025
        /// </param>
        /// <param name="semantics">
        /// Default Value: default
        /// </param>
        /// <param name="query">
        /// Query override for this specific corpus.
        /// </param>
        public AgentKeyedSearchCorpus(
            global::G.OneOf<string, global::G.EagerReference> corpusKey,
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions,
            global::G.OneOf<string, global::G.EagerReference>? metadataFilter,
            float? lexicalInterpolation,
            global::G.SearchSemantics? semantics,
            string? query)
        {
            this.CorpusKey = corpusKey;
            this.CustomDimensions = customDimensions;
            this.MetadataFilter = metadataFilter;
            this.LexicalInterpolation = lexicalInterpolation;
            this.Semantics = semantics;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKeyedSearchCorpus" /> class.
        /// </summary>
        public AgentKeyedSearchCorpus()
        {
        }
    }
}