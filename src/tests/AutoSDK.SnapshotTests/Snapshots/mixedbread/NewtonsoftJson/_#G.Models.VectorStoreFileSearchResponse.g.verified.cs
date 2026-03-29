//HintName: G.Models.VectorStoreFileSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search response wrapper for vector store files.
    /// </summary>
    public sealed partial class VectorStoreFileSearchResponse
    {
        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of scored vector store files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScoredVectorStoreFile> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileSearchResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of scored vector store files
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        public VectorStoreFileSearchResponse(
            global::System.Collections.Generic.IList<global::G.ScoredVectorStoreFile> data,
            string? @object)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileSearchResponse" /> class.
        /// </summary>
        public VectorStoreFileSearchResponse()
        {
        }
    }
}