//HintName: G.Models.GetAnalyticsGroupsAiModelsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsAiModelsResponseDataItem
    {
        /// <summary>
        /// The ai model for which the data is calculated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// Total requests made for this ai model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public string? Requests { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsAiModelsResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="aiModel">
        /// The ai model for which the data is calculated
        /// </param>
        /// <param name="requests">
        /// Total requests made for this ai model
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
        public GetAnalyticsGroupsAiModelsResponseDataItem(
            string? aiModel,
            string? requests,
            global::G.GetAnalyticsGroupsAiModelsResponseDataItemObject? @object)
        {
            this.AiModel = aiModel;
            this.Requests = requests;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsAiModelsResponseDataItem()
        {
        }
    }
}