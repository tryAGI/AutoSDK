//HintName: G.Models.UpdateCollectionRecordsPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload for updating existing records in a collection.<br/>
    /// Records are added in batches. All arrays must have the same length, with each index<br/>
    /// representing a single record. For example, `ids[0]`, `embeddings[0]`, `documents[0]`, etc.<br/>
    /// all belong to the same record.
    /// </summary>
    public sealed partial class UpdateCollectionRecordsPayload
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateEmbeddingsPayload?>))]
        public global::G.OneOf<object, global::G.UpdateEmbeddingsPayload?>? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateCollectionRecordsPayload" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCollectionRecordsPayload(
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents,
            global::G.OneOf<object, global::G.UpdateEmbeddingsPayload?>? embeddings,
            global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? metadatas,
            global::System.Collections.Generic.IList<string>? uris)
        {
            this.Documents = documents;
            this.Embeddings = embeddings;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Metadatas = metadatas;
            this.Uris = uris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionRecordsPayload" /> class.
        /// </summary>
        public UpdateCollectionRecordsPayload()
        {
        }
    }
}