//HintName: G.Models.EmbeddingsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsResponse200
    {
        /// <summary>
        /// Unique ID for the embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the embeddings was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The embeddings model used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of vectorized data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the embeddings.
        /// </param>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the embeddings was created.
        /// </param>
        /// <param name="model">
        /// The embeddings model used.
        /// </param>
        /// <param name="data">
        /// The set of vectorized data.
        /// </param>
        public EmbeddingsResponse200(
            string? id,
            string? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>? data)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse200" /> class.
        /// </summary>
        public EmbeddingsResponse200()
        {
        }
    }
}