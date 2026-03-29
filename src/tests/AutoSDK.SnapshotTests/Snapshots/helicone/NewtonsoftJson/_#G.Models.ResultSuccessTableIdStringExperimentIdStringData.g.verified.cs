//HintName: G.Models.ResultSuccessTableIdStringExperimentIdStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessTableIdStringExperimentIdStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tableId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TableId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTableIdStringExperimentIdStringData" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="tableId"></param>
        public ResultSuccessTableIdStringExperimentIdStringData(
            string experimentId,
            string tableId)
        {
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
            this.TableId = tableId ?? throw new global::System.ArgumentNullException(nameof(tableId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTableIdStringExperimentIdStringData" /> class.
        /// </summary>
        public ResultSuccessTableIdStringExperimentIdStringData()
        {
        }
    }
}