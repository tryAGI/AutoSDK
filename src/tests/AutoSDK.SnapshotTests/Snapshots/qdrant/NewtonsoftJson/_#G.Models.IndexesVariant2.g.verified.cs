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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.IndexesVariant2Type Type { get; set; }

        /// <summary>
        /// Config of HNSW index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HnswConfig Options { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVariant2" /> class.
        /// </summary>
        /// <param name="options">
        /// Config of HNSW index
        /// </param>
        /// <param name="type"></param>
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