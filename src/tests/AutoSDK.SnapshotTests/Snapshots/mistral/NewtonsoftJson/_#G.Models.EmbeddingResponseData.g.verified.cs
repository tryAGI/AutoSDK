//HintName: G.Models.EmbeddingResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingResponseData
    {
        /// <summary>
        /// Example: embedding
        /// </summary>
        /// <example>embedding</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: [0.1, 0.2, 0.3]
        /// </summary>
        /// <example>[0.1, 0.2, 0.3]</example>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseData" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: embedding
        /// </param>
        /// <param name="embedding">
        /// Example: [0.1, 0.2, 0.3]
        /// </param>
        /// <param name="index">
        /// Example: 0
        /// </param>
        public EmbeddingResponseData(
            string? @object,
            global::System.Collections.Generic.IList<double>? embedding,
            int? index)
        {
            this.Object = @object;
            this.Embedding = embedding;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseData" /> class.
        /// </summary>
        public EmbeddingResponseData()
        {
        }
    }
}