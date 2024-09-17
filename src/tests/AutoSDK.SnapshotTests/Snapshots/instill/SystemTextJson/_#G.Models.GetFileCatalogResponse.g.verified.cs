//HintName: G.Models.GetFileCatalogResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.GetFileCatalogResponseMetadata>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.GetFileCatalogResponseText>? Text { get; set; }

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
    }
}