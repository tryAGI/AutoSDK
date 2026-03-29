//HintName: G.Models.GetIntegrationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntegrationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.GetIntegrationsResponseObject? Object { get; set; }

        /// <summary>
        /// Total number of integrations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.IntegrationList>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationsResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="total">
        /// Total number of integrations
        /// </param>
        /// <param name="data"></param>
        public GetIntegrationsResponse(
            global::G.GetIntegrationsResponseObject? @object,
            int? total,
            global::System.Collections.Generic.IList<global::G.IntegrationList>? data)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationsResponse" /> class.
        /// </summary>
        public GetIntegrationsResponse()
        {
        }
    }
}