//HintName: G.Models.SummarizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizeResponse
    {
        /// <summary>
        /// Generated ID for the summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Generated summary for the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Generated ID for the summary
        /// </param>
        /// <param name="summary">
        /// Generated summary for the text
        /// </param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SummarizeResponse(
            string? id,
            string? summary,
            global::G.ApiMeta? meta)
        {
            this.Id = id;
            this.Summary = summary;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeResponse" /> class.
        /// </summary>
        public SummarizeResponse()
        {
        }
    }
}