//HintName: G.Models.SaveDraftDatasetVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveDraftDatasetVersionRequest
    {
        /// <summary>
        /// ID of the dataset group containing the draft to save
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft to save
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveDraftDatasetVersionRequest(
            int datasetGroupId)
        {
            this.DatasetGroupId = datasetGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionRequest" /> class.
        /// </summary>
        public SaveDraftDatasetVersionRequest()
        {
        }
    }
}