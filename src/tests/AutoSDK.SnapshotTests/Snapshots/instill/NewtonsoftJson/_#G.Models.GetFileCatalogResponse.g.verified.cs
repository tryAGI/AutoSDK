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
        [global::Newtonsoft.Json.JsonProperty("originalData")]
        public string? OriginalData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.Text? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks")]
        public global::System.Collections.Generic.IList<global::G.GetFileCatalogResponseChunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponse" /> class.
        /// </summary>
        /// <param name="originalData"></param>
        /// <param name="metadata"></param>
        /// <param name="text"></param>
        /// <param name="chunks"></param>
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