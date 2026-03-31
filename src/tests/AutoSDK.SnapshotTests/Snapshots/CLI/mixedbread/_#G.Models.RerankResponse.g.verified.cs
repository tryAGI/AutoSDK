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
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Usage Usage { get; set; }

        /// <summary>
        /// The model used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The ranked documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RankedDocument> Data { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The number of documents to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopK { get; set; }

        /// <summary>
        /// Whether to return the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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