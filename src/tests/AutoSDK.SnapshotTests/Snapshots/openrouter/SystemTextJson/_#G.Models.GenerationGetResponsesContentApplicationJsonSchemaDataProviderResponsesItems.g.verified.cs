//HintName: G.Models.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        public string? ModelPermaslug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderNameJsonConverter))]
        public global::G.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderName? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endpointId"></param>
        /// <param name="modelPermaslug"></param>
        /// <param name="providerName"></param>
        /// <param name="status"></param>
        /// <param name="latency"></param>
        /// <param name="isByok"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems(
            string? id,
            string? endpointId,
            string? modelPermaslug,
            global::G.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderName? providerName,
            double? status,
            double? latency,
            bool? isByok)
        {
            this.Id = id;
            this.EndpointId = endpointId;
            this.ModelPermaslug = modelPermaslug;
            this.ProviderName = providerName;
            this.Status = status;
            this.Latency = latency;
            this.IsByok = isByok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems" /> class.
        /// </summary>
        public GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems()
        {
        }
    }
}