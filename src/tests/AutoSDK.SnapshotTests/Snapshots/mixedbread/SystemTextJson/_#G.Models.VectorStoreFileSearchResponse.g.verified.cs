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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of scored vector store files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScoredVectorStoreFile> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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