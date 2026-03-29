//HintName: G.Models.DateRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DateRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_ms")]
        public double? EndTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange" /> class.
        /// </summary>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DateRange(
            double startTimeMs,
            double? endTimeMs)
        {
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange" /> class.
        /// </summary>
        public DateRange()
        {
        }
    }
}