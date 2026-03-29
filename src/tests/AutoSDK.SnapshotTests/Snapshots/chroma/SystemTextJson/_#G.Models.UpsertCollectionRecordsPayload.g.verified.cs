//HintName: G.Models.UpsertCollectionRecordsPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload for upserting records in a collection.<br/>
    /// Upsert creates records if they don't exist, or updates them if they do.<br/>
    /// Records are added in batches. All arrays must have the same length, with each index<br/>
    /// representing a single record. For example, `ids[0]`, `embeddings[0]`, `documents[0]`, etc.<br/>
    /// all belong to the same record.
    /// </summary>
    public sealed partial class UpsertCollectionRecordsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<string>? Documents { get; set; }

        /// <summary>
        /// Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingsPayloadJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingsPayload Embeddings { get; set; }

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
        /// Initializes a new instance of the <see cref="UpsertCollectionRecordsPayload" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.
        /// </param>
        /// <param name="ids"></param>
        /// <param name="documents"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertCollectionRecordsPayload(
            global::G.EmbeddingsPayload embeddings,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents,
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
        /// Initializes a new instance of the <see cref="UpsertCollectionRecordsPayload" /> class.
        /// </summary>
        public UpsertCollectionRecordsPayload()
        {
        }
    }
}