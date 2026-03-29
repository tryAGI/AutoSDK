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
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadatas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>> Metadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Key>> Select { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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