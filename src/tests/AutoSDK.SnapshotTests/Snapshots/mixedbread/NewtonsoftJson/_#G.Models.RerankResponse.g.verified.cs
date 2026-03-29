//HintName: G.Models.RerankResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponse
    {
        /// <summary>
        /// The usage of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Usage Usage { get; set; } = default!;

        /// <summary>
        /// The model used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The ranked documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RankedDocument> Data { get; set; } = default!;

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The number of documents to return.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k", Required = global::Newtonsoft.Json.Required.Always)]
        public int TopK { get; set; } = default!;

        /// <summary>
        /// Whether to return the documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_input", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ReturnInput { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// The usage of the model
        /// </param>
        /// <param name="model">
        /// The model used
        /// </param>
        /// <param name="data">
        /// The ranked documents.
        /// </param>
        /// <param name="topK">
        /// The number of documents to return.
        /// </param>
        /// <param name="returnInput">
        /// Whether to return the documents.
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        public RerankResponse(
            global::G.Usage usage,
            string model,
            global::System.Collections.Generic.IList<global::G.RankedDocument> data,
            int topK,
            bool returnInput,
            string? @object)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
            this.TopK = topK;
            this.ReturnInput = returnInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        public RerankResponse()
        {
        }
    }
}