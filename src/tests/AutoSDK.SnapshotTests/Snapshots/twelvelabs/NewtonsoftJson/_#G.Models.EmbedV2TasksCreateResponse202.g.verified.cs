//HintName: G.Models.EmbedV2TasksCreateResponse202.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedV2TasksCreateResponse202
    {
        /// <summary>
        /// The unique identifier of the embedding task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The initial status of the embedding task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter))]
        public global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus Status { get; set; }

        /// <summary>
        /// An array of embedding results when `status` is `ready`, or `null` when `status` is `processing` or `failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingData>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksCreateResponse202" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the embedding task
        /// </param>
        /// <param name="status">
        /// The initial status of the embedding task.
        /// </param>
        /// <param name="data">
        /// An array of embedding results when `status` is `ready`, or `null` when `status` is `processing` or `failed`.
        /// </param>
        public EmbedV2TasksCreateResponse202(
            string id,
            global::G.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus status,
            global::System.Collections.Generic.IList<global::G.EmbeddingData>? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksCreateResponse202" /> class.
        /// </summary>
        public EmbedV2TasksCreateResponse202()
        {
        }
    }
}