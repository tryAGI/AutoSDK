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
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_internal_btql")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InternalBtql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataDatasetId" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="internalBtql"></param>
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