//HintName: G.Models.ErrorCountWithDeviationDetailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ErrorCountWithDeviationDetailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deviation")]
        public long? Deviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deviation_percentage")]
        public long? DeviationPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCountWithDeviationDetailed" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="deviation"></param>
        /// <param name="deviationPercentage"></param>
        public ErrorCountWithDeviationDetailed(
            long? count,
            long? deviation,
            long? deviationPercentage)
        {
            this.Count = count;
            this.Deviation = deviation;
            this.DeviationPercentage = deviationPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCountWithDeviationDetailed" /> class.
        /// </summary>
        public ErrorCountWithDeviationDetailed()
        {
        }
    }
}