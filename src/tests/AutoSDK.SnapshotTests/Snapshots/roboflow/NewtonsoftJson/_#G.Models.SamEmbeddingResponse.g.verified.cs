//HintName: G.Models.SamEmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM embedding response.<br/>
    /// Attributes:<br/>
    ///     embeddings (Union[List[List[List[List[float]]]], Any]): The SAM embedding.<br/>
    ///     time (float): The time in seconds it took to produce the embeddings including preprocessing.
    /// </summary>
    public sealed partial class SamEmbeddingResponse
    {
        /// <summary>
        /// If request format is json, embeddings is a series of nested lists representing the SAM embedding. If request format is binary, embeddings is a binary numpy array. The dimensions of the embedding are 1 x 256 x 64 x 64.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object> Embeddings { get; set; } = default!;

        /// <summary>
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// If request format is json, embeddings is a series of nested lists representing the SAM embedding. If request format is binary, embeddings is a binary numpy array. The dimensions of the embedding are 1 x 256 x 64 x 64.
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </param>
        public SamEmbeddingResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object> embeddings,
            double time)
        {
            this.Embeddings = embeddings;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingResponse" /> class.
        /// </summary>
        public SamEmbeddingResponse()
        {
        }
    }
}