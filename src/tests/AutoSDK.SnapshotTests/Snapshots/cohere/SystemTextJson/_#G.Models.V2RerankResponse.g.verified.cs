//HintName: G.Models.V2RerankResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2RerankResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.V2RerankResponseResultsItem> Results { get; set; }

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
        /// Initializes a new instance of the <see cref="V2RerankResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// An ordered list of ranked documents
        /// </param>
        /// <param name="id"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2RerankResponse(
            global::System.Collections.Generic.IList<global::G.V2RerankResponseResultsItem> results,
            string? id,
            global::G.ApiMeta? meta)
        {
            this.Id = id;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2RerankResponse" /> class.
        /// </summary>
        public V2RerankResponse()
        {
        }
    }
}