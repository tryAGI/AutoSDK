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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToFirstToken")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedTiming" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="timeToFirstToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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