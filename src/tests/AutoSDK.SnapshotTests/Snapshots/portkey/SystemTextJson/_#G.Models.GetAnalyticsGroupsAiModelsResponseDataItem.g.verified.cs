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
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// Total requests made for this ai model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public string? Requests { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsAiModelsResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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