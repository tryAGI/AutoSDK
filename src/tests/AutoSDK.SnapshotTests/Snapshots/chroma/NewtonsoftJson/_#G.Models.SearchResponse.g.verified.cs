//HintName: G.Models.SearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Documents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> Embeddings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadatas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>> Metadatas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> Scores { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("select", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Key>> Select { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="ids"></param>
        /// <param name="metadatas"></param>
        /// <param name="scores"></param>
        /// <param name="select"></param>
        public SearchResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> documents,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> embeddings,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> ids,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>> metadatas,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> scores,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Key>> select)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Embeddings = embeddings ?? throw new global::System.ArgumentNullException(nameof(embeddings));
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Metadatas = metadatas ?? throw new global::System.ArgumentNullException(nameof(metadatas));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.Select = select ?? throw new global::System.ArgumentNullException(nameof(select));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}