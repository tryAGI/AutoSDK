//HintName: G.Models.MultimodalEmbeddingsApiResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalEmbeddingsApiResponse
    {
        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// An array of embedding objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.MultimodalEmbeddingsApiResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.MultimodalEmbeddingsApiResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
        /// <param name="data">
        /// An array of embedding objects.
        /// </param>
        /// <param name="model">
        /// Name of the model.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalEmbeddingsApiResponse(
            string? @object,
            global::System.Collections.Generic.IList<global::G.MultimodalEmbeddingsApiResponseDataItem>? data,
            string? model,
            global::G.MultimodalEmbeddingsApiResponseUsage? usage)
        {
            this.Object = @object;
            this.Data = data;
            this.Model = model;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponse" /> class.
        /// </summary>
        public MultimodalEmbeddingsApiResponse()
        {
        }
    }
}