//HintName: G.Models.ErrorOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="count"></param>
        public ErrorOverTime(
            global::System.DateTime time,
            double count)
        {
            this.Time = time;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorOverTime" /> class.
        /// </summary>
        public ErrorOverTime()
        {
        }
    }
}