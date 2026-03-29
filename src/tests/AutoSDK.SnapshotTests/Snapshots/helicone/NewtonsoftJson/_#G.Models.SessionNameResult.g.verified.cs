//HintName: G.Models.SessionNameResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionNameResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastUsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_used", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstUsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double SessionCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_latency", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgLatency { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNameResult" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUsed"></param>
        /// <param name="firstUsed"></param>
        /// <param name="sessionCount"></param>
        /// <param name="avgLatency"></param>
        public SessionNameResult(
            string name,
            string createdAt,
            string lastUsed,
            string firstUsed,
            double sessionCount,
            double avgLatency)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.LastUsed = lastUsed ?? throw new global::System.ArgumentNullException(nameof(lastUsed));
            this.FirstUsed = firstUsed ?? throw new global::System.ArgumentNullException(nameof(firstUsed));
            this.SessionCount = sessionCount;
            this.AvgLatency = avgLatency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNameResult" /> class.
        /// </summary>
        public SessionNameResult()
        {
        }
    }
}