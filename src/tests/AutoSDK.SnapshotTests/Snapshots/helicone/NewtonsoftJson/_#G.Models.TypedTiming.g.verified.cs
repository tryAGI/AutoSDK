//HintName: G.Models.TypedTiming.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypedTiming
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeToFirstToken")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedTiming" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="timeToFirstToken"></param>
        public TypedTiming(
            string startTime,
            string endTime,
            double? timeToFirstToken)
        {
            this.TimeToFirstToken = timeToFirstToken;
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedTiming" /> class.
        /// </summary>
        public TypedTiming()
        {
        }
    }
}