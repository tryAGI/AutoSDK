//HintName: G.Models.ResultSuccessHypothesisIdStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessHypothesisIdStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hypothesisId", Required = global::Newtonsoft.Json.Required.Always)]
        public string HypothesisId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHypothesisIdStringData" /> class.
        /// </summary>
        /// <param name="hypothesisId"></param>
        public ResultSuccessHypothesisIdStringData(
            string hypothesisId)
        {
            this.HypothesisId = hypothesisId ?? throw new global::System.ArgumentNullException(nameof(hypothesisId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHypothesisIdStringData" /> class.
        /// </summary>
        public ResultSuccessHypothesisIdStringData()
        {
        }
    }
}