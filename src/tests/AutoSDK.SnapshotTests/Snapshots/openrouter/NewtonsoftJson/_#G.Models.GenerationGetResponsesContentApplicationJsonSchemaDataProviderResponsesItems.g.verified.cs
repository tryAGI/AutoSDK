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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_permaslug")]
        public string? ModelPermaslug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderNameJsonConverter))]
        public global::G.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderName? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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