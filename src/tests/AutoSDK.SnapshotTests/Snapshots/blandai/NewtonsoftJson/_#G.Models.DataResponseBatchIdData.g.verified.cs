//HintName: G.Models.DataResponseBatchIdData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataResponseBatchIdData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResponseBatchIdData" /> class.
        /// </summary>
        /// <param name="batchId"></param>
        public DataResponseBatchIdData(
            string? batchId)
        {
            this.BatchId = batchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResponseBatchIdData" /> class.
        /// </summary>
        public DataResponseBatchIdData()
        {
        }
    }
}