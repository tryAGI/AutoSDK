//HintName: G.Models.LatencyOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LatencyOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="duration"></param>
        public LatencyOverTime(
            global::System.DateTime time,
            double duration)
        {
            this.Time = time;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyOverTime" /> class.
        /// </summary>
        public LatencyOverTime()
        {
        }
    }
}