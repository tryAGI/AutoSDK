//HintName: G.Models.IndexesVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use filterable HNSW index for approximate search. Is very fast even on a very huge collections, but require additional space to store index and additional time to build it.
    /// </summary>
    public sealed partial class IndexesVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IndexesVariant2TypeJsonConverter))]
        public global::G.IndexesVariant2Type Type { get; set; }

        /// <summary>
        /// Config of HNSW index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HnswConfig Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVariant2" /> class.
        /// </summary>
        /// <param name="options">
        /// Config of HNSW index
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesVariant2(
            global::G.HnswConfig options,
            global::G.IndexesVariant2Type type)
        {
            this.Type = type;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVariant2" /> class.
        /// </summary>
        public IndexesVariant2()
        {
        }
    }
}