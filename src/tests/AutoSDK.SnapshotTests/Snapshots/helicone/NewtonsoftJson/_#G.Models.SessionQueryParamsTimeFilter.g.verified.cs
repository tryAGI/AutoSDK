//HintName: G.Models.SessionQueryParamsTimeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionQueryParamsTimeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixMs", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTimeUnixMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixMs", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimeUnixMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionQueryParamsTimeFilter" /> class.
        /// </summary>
        /// <param name="endTimeUnixMs"></param>
        /// <param name="startTimeUnixMs"></param>
        public SessionQueryParamsTimeFilter(
            double endTimeUnixMs,
            double startTimeUnixMs)
        {
            this.EndTimeUnixMs = endTimeUnixMs;
            this.StartTimeUnixMs = startTimeUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionQueryParamsTimeFilter" /> class.
        /// </summary>
        public SessionQueryParamsTimeFilter()
        {
        }
    }
}