//HintName: G.Models.EmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingResponse
    {
        /// <summary>
        /// The object type, always "list".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingResponseObjectJsonConverter))]
        public global::G.EmbeddingResponseObject? Object { get; set; }

        /// <summary>
        /// A list of embedding objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingData>? Data { get; set; }

        /// <summary>
        /// The model used for the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.EmbeddingUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, always "list".
        /// </param>
        /// <param name="data">
        /// A list of embedding objects.
        /// </param>
        /// <param name="model">
        /// The model used for the embedding.
        /// </param>
        /// <param name="usage"></param>
        public EmbeddingResponse(
            global::G.EmbeddingResponseObject? @object,
            global::System.Collections.Generic.IList<global::G.EmbeddingData>? data,
            string? model,
            global::G.EmbeddingUsage? usage)
        {
            this.Object = @object;
            this.Data = data;
            this.Model = model;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        public EmbeddingResponse()
        {
        }
    }
}