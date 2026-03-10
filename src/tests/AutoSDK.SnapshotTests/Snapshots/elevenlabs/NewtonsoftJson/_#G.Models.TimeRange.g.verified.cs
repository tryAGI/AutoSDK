//HintName: G.Models.TimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        /// <param name="startMs"></param>
        /// <param name="endMs"></param>
        public TimeRange(
            int startMs,
            int endMs)
        {
            this.StartMs = startMs;
            this.EndMs = endMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        public TimeRange()
        {
        }
    }
}