//HintName: G.Models.ResultSuccessExperimentIdStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessExperimentIdStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessExperimentIdStringData" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        public ResultSuccessExperimentIdStringData(
            string experimentId)
        {
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessExperimentIdStringData" /> class.
        /// </summary>
        public ResultSuccessExperimentIdStringData()
        {
        }
    }
}