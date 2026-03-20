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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.V2RerankResponseResultsItem> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2RerankResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="results">
        /// An ordered list of ranked documents
        /// </param>
        /// <param name="meta"></param>
        public V2RerankResponse(
            global::System.Collections.Generic.IList<global::G.V2RerankResponseResultsItem> results,
            string? id,
            global::G.ApiMeta? meta)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Id = id;
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