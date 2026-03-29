//HintName: G.Models.QueryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distances")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Distances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Include> Include { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadatas")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>>? Metadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uris")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Uris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponse" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="distances"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
        public QueryResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> ids,
            global::System.Collections.Generic.IList<global::G.Include> include,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? distances,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? documents,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? embeddings,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>>? metadatas,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? uris)
        {
            this.Distances = distances;
            this.Documents = documents;
            this.Embeddings = embeddings;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Include = include ?? throw new global::System.ArgumentNullException(nameof(include));
            this.Metadatas = metadatas;
            this.Uris = uris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponse" /> class.
        /// </summary>
        public QueryResponse()
        {
        }
    }
}