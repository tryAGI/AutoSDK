//HintName: G.Models.GetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All arrays have the same length, with each index representing a single record.<br/>
    /// Only fields specified in the request's `include` parameter are populated.
    /// </summary>
    public sealed partial class GetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<string>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// List of fields that were included in this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Include> Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadatas")]
        public global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? Metadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponse" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="include">
        /// List of fields that were included in this response.
        /// </param>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetResponse(
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<global::G.Include> include,
            global::System.Collections.Generic.IList<string>? documents,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? embeddings,
            global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? metadatas,
            global::System.Collections.Generic.IList<string>? uris)
        {
            this.Documents = documents;
            this.Embeddings = embeddings;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Include = include ?? throw new global::System.ArgumentNullException(nameof(include));
            this.Metadatas = metadatas;
            this.Uris = uris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponse" /> class.
        /// </summary>
        public GetResponse()
        {
        }
    }
}