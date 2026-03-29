//HintName: G.Models.GetScoresResponseDataCategorical.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseDataCategorical
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace")]
        public global::G.GetScoresResponseTraceData? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataCategorical" /> class.
        /// </summary>
        /// <param name="trace"></param>
        public GetScoresResponseDataCategorical(
            global::G.GetScoresResponseTraceData? trace)
        {
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataCategorical" /> class.
        /// </summary>
        public GetScoresResponseDataCategorical()
        {
        }
    }
}