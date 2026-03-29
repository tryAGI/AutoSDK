//HintName: G.Models.LocalRunnerJobMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerJobMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version_id")]
        public global::System.Guid? DatasetVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_version_id")]
        public global::System.Guid? DatasetItemVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_id")]
        public global::System.Guid? DatasetItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobMetadata" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="datasetVersionId"></param>
        /// <param name="datasetItemVersionId"></param>
        /// <param name="datasetItemId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerJobMetadata(
            global::System.Guid? datasetId,
            global::System.Guid? datasetVersionId,
            global::System.Guid? datasetItemVersionId,
            global::System.Guid? datasetItemId)
        {
            this.DatasetId = datasetId;
            this.DatasetVersionId = datasetVersionId;
            this.DatasetItemVersionId = datasetItemVersionId;
            this.DatasetItemId = datasetItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobMetadata" /> class.
        /// </summary>
        public LocalRunnerJobMetadata()
        {
        }
    }
}