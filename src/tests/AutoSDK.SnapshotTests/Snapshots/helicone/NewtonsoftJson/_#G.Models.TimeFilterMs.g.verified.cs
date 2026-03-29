//HintName: G.Models.TimeFilterMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeFilterMs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixMs", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimeUnixMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixMs", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTimeUnixMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterMs" /> class.
        /// </summary>
        /// <param name="startTimeUnixMs"></param>
        /// <param name="endTimeUnixMs"></param>
        public TimeFilterMs(
            double startTimeUnixMs,
            double endTimeUnixMs)
        {
            this.StartTimeUnixMs = startTimeUnixMs;
            this.EndTimeUnixMs = endTimeUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterMs" /> class.
        /// </summary>
        public TimeFilterMs()
        {
        }
    }
}