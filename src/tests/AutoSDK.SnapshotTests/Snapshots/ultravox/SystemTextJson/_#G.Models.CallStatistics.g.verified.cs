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
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Total duration of all calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// Number of calls that were joined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JoinedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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