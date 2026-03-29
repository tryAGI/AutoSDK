//HintName: G.Models.CostOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="cost"></param>
        public CostOverTime(
            global::System.DateTime time,
            double cost)
        {
            this.Time = time;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostOverTime" /> class.
        /// </summary>
        public CostOverTime()
        {
        }
    }
}