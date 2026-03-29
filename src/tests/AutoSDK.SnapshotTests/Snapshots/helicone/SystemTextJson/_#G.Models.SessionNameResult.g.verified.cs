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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgLatency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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