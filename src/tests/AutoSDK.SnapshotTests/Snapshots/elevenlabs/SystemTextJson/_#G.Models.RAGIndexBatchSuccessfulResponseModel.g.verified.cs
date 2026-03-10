//HintName: G.Models.RAGIndexBatchSuccessfulResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGIndexBatchSuccessfulResponseModel
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RAGDocumentIndexResponseModel Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexBatchSuccessfulResponseModel" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGIndexBatchSuccessfulResponseModel(
            global::G.RAGDocumentIndexResponseModel data,
            string status = "success")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexBatchSuccessfulResponseModel" /> class.
        /// </summary>
        public RAGIndexBatchSuccessfulResponseModel()
        {
        }
    }
}