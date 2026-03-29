//HintName: G.Models.TimeCost1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeCost1
    {
        /// <summary>
        /// ms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost1" /> class.
        /// </summary>
        /// <param name="totalDurationMs">
        /// ms
        /// </param>
        public TimeCost1(
            int? totalDurationMs)
        {
            this.TotalDurationMs = totalDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost1" /> class.
        /// </summary>
        public TimeCost1()
        {
        }
    }
}