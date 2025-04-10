//HintName: G.Models.CallStatistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallStatistics
    {
        /// <summary>
        /// Total number of calls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Total duration of all calls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// Number of calls that were joined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joinedCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int JoinedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatistics" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Total number of calls
        /// </param>
        /// <param name="duration">
        /// Total duration of all calls
        /// </param>
        /// <param name="joinedCount">
        /// Number of calls that were joined
        /// </param>
        public CallStatistics(
            int totalCount,
            string duration,
            int joinedCount)
        {
            this.TotalCount = totalCount;
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.JoinedCount = joinedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatistics" /> class.
        /// </summary>
        public CallStatistics()
        {
        }
    }
}