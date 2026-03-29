//HintName: G.Models.AttributeSchemaConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed configuration for an attribute attached to a document.
    /// </summary>
    public sealed partial class AttributeSchemaConfig
    {
        /// <summary>
        /// The data type of the attribute. Valid values: string, int, uint, float, uuid, datetime, bool, []string, []int, []uint, []float, []uuid, []datetime, []bool, [DIMS]f16, [DIMS]f32.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether or not the attributes can be used in filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterable")]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Whether to enable Regex filters on this attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public bool? Regex { get; set; }

        /// <summary>
        /// Whether this attribute can be used as part of a BM25 full-text search. Requires the `string` or `[]string` type, and by default, BM25-enabled attributes are not filterable. You can override this by setting `filterable: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_text_search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FullTextSearchJsonConverter))]
        public global::G.FullTextSearch? FullTextSearch { get; set; }

        /// <summary>
        /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnnJsonConverter))]
        public global::G.Ann? Ann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The data type of the attribute. Valid values: string, int, uint, float, uuid, datetime, bool, []string, []int, []uint, []float, []uuid, []datetime, []bool, [DIMS]f16, [DIMS]f32.
        /// </param>
        /// <param name="filterable">
        /// Whether or not the attributes can be used in filters.
        /// </param>
        /// <param name="regex">
        /// Whether to enable Regex filters on this attribute.
        /// </param>
        /// <param name="fullTextSearch">
        /// Whether this attribute can be used as part of a BM25 full-text search. Requires the `string` or `[]string` type, and by default, BM25-enabled attributes are not filterable. You can override this by setting `filterable: true`.
        /// </param>
        /// <param name="ann">
        /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeSchemaConfig(
            string type,
            bool? filterable,
            bool? regex,
            global::G.FullTextSearch? fullTextSearch,
            global::G.Ann? ann)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Filterable = filterable;
            this.Regex = regex;
            this.FullTextSearch = fullTextSearch;
            this.Ann = ann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaConfig" /> class.
        /// </summary>
        public AttributeSchemaConfig()
        {
        }
    }
}