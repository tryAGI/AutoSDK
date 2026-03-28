//HintName: G.Models.KnowledgeBaseSummaryBatchSuccessfulResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseSummaryBatchSuccessfulResponseModel
    {
        /// <summary>
        /// Default Value: success
        /// </summary>
        /// <default>"success"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "success";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSummaryBatchSuccessfulResponseModel" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseSummaryBatchSuccessfulResponseModel(
            global::G.Data data,
            string status = "success")
        {
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSummaryBatchSuccessfulResponseModel" /> class.
        /// </summary>
        public KnowledgeBaseSummaryBatchSuccessfulResponseModel()
        {
        }
    }
}