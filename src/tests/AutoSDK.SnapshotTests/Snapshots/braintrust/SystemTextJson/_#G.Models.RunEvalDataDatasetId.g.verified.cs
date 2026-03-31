//HintName: G.Models.RunEvalDataDatasetId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset id
    /// </summary>
    public sealed partial class RunEvalDataDatasetId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_internal_btql")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InternalBtql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataDatasetId" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="internalBtql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunEvalDataDatasetId(
            string datasetId,
            global::System.Collections.Generic.Dictionary<string, object?>? internalBtql)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.InternalBtql = internalBtql;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataDatasetId" /> class.
        /// </summary>
        public RunEvalDataDatasetId()
        {
        }
    }
}