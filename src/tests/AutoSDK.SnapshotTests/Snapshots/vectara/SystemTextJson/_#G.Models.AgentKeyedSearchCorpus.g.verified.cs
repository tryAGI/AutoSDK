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
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::G.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::G.EagerReference> CorpusKey { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The filter to narrow search results. Can be either a static string (e.g. "doc.department = 'engineering'") or an EagerReference object (e.g. {"$ref": "session.metadata.filters.user"}). When an EagerReference is provided, the $ref path is resolved from the session context at the start of each turn, before LLM processing begins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::G.EagerReference>))]
        public global::G.OneOf<string, global::G.EagerReference>? MetadataFilter { get; set; }

        /// <summary>
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Default Value: 0.025
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_interpolation")]
        public float? LexicalInterpolation { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchSemanticsJsonConverter))]
        public global::G.SearchSemantics? Semantics { get; set; }

        /// <summary>
        /// Query override for this specific corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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