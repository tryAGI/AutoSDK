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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model to be used for the rerank request.<br/>
        /// Example: salesforce/turboranker-0.8-3778-6328
        /// </summary>
        /// <example>salesforce/turboranker-0.8-3778-6328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Object type<br/>
        /// Example: rerank
        /// </summary>
        /// <example>rerank</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RerankResponseObjectJsonConverter))]
        public global::G.RerankResponseObject Object { get; set; }

        /// <summary>
        /// Example: [, ]
        /// </summary>
        /// <example>[, ]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RerankResponseResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.UsageData? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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