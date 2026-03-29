//HintName: G.Models.TimeInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeInterval
    {
        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("begin")]
        public double? Begin { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        /// <param name="begin">
        /// Start time in seconds
        /// </param>
        /// <param name="end">
        /// End time in seconds
        /// </param>
        public TimeInterval(
            double? begin,
            double? end)
        {
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        public TimeInterval()
        {
        }
    }
}