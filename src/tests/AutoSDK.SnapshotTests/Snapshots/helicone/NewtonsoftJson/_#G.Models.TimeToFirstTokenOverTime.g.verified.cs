//HintName: G.Models.TimeToFirstTokenOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeToFirstTokenOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft", Required = global::Newtonsoft.Json.Required.Always)]
        public double Ttft { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToFirstTokenOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="ttft"></param>
        public TimeToFirstTokenOverTime(
            global::System.DateTime time,
            double ttft)
        {
            this.Time = time;
            this.Ttft = ttft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToFirstTokenOverTime" /> class.
        /// </summary>
        public TimeToFirstTokenOverTime()
        {
        }
    }
}