//HintName: G.Models.TimeWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeWindow
    {
        /// <summary>
        /// Start time in minutes since local midnight.<br/>
        /// Example: 540
        /// </summary>
        /// <example>540</example>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End time in minutes since local midnight.<br/>
        /// Example: 1020
        /// </summary>
        /// <example>1020</example>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeWindow" /> class.
        /// </summary>
        /// <param name="start">
        /// Start time in minutes since local midnight.<br/>
        /// Example: 540
        /// </param>
        /// <param name="end">
        /// End time in minutes since local midnight.<br/>
        /// Example: 1020
        /// </param>
        public TimeWindow(
            double start,
            double end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeWindow" /> class.
        /// </summary>
        public TimeWindow()
        {
        }
    }
}