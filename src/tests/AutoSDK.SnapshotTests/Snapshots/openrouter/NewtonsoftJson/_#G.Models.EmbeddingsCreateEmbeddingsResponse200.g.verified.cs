//HintName: G.Models.EmbeddingsCreateEmbeddingsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsCreateEmbeddingsResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsCreateEmbeddingsResponse200" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="usage"></param>
        public EmbeddingsCreateEmbeddingsResponse200(
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems> data,
            string model,
            string? id,
            global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaObject @object,
            global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsCreateEmbeddingsResponse200" /> class.
        /// </summary>
        public EmbeddingsCreateEmbeddingsResponse200()
        {
        }
    }
}