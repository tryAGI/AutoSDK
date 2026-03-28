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
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "success";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Data Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSummaryBatchSuccessfulResponseModel" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
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