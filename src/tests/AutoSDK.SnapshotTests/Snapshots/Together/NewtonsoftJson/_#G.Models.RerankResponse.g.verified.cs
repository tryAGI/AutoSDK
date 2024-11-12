//HintName: G.Models.RerankResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponse
    {
        /// <summary>
        /// Request ID<br/>
        /// Example: 9dfa1a09-5ebc-4a40-970f-586cb8f4ae47
        /// </summary>
        /// <example>9dfa1a09-5ebc-4a40-970f-586cb8f4ae47</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model to be used for the rerank request.<br/>
        /// Example: salesforce/turboranker-0.8-3778-6328
        /// </summary>
        /// <example>salesforce/turboranker-0.8-3778-6328</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Object type<br/>
        /// Example: rerank
        /// </summary>
        /// <example>rerank</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.RerankResponseObject Object { get; set; }

        /// <summary>
        /// Example: [, ]
        /// </summary>
        /// <example>[, ]</example>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RerankResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.UsageData? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Request ID<br/>
        /// Example: 9dfa1a09-5ebc-4a40-970f-586cb8f4ae47
        /// </param>
        /// <param name="model">
        /// The model to be used for the rerank request.<br/>
        /// Example: salesforce/turboranker-0.8-3778-6328
        /// </param>
        /// <param name="object">
        /// Object type<br/>
        /// Example: rerank
        /// </param>
        /// <param name="results">
        /// Example: [, ]
        /// </param>
        /// <param name="usage"></param>
        public RerankResponse(
            string model,
            global::System.Collections.Generic.IList<global::G.RerankResponseResult> results,
            string? id,
            global::G.RerankResponseObject @object,
            global::G.UsageData? usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Id = id;
            this.Object = @object;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        public RerankResponse()
        {
        }
    }
}