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
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<string>? Documents { get; set; }

        /// <summary>
        /// Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingsPayload Embeddings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadatas")]
        public global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? Metadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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