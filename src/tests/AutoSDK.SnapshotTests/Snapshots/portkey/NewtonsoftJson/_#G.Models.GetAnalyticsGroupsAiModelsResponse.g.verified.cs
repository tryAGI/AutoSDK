//HintName: G.Models.GetAnalyticsGroupsAiModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsAiModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsAiModelsResponseObject Object { get; set; }

        /// <summary>
        /// Total records present across all pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsAiModelsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total records present across all pages
        /// </param>
        /// <param name="data"></param>
        /// <param name="object"></param>
        public GetAnalyticsGroupsAiModelsResponse(
            int total,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsAiModelsResponseDataItem> data,
            global::G.GetAnalyticsGroupsAiModelsResponseObject @object)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponse" /> class.
        /// </summary>
        public GetAnalyticsGroupsAiModelsResponse()
        {
        }
    }
}