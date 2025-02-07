//HintName: G.Models.GetFileCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFileCatalogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalData")]
        public string? OriginalData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::G.Text? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::G.GetFileCatalogResponseChunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponse" /> class.
        /// </summary>
        /// <param name="originalData"></param>
        /// <param name="metadata"></param>
        /// <param name="text"></param>
        /// <param name="chunks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileCatalogResponse(
            string? originalData,
            global::G.Metadata? metadata,
            global::G.Text? text,
            global::System.Collections.Generic.IList<global::G.GetFileCatalogResponseChunk>? chunks)
        {
            this.OriginalData = originalData;
            this.Metadata = metadata;
            this.Text = text;
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponse" /> class.
        /// </summary>
        public GetFileCatalogResponse()
        {
        }
    }
}