//HintName: G.Models.ResultSuccessDatasetIdStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessDatasetIdStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessDatasetIdStringData" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        public ResultSuccessDatasetIdStringData(
            string datasetId)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessDatasetIdStringData" /> class.
        /// </summary>
        public ResultSuccessDatasetIdStringData()
        {
        }
    }
}