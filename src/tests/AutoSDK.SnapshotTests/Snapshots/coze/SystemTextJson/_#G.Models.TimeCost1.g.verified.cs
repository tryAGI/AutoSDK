//HintName: G.Models.TimeCost1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeCost1
    {
        /// <summary>
        /// ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost1" /> class.
        /// </summary>
        /// <param name="totalDurationMs">
        /// ms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeCost1(
            int? totalDurationMs)
        {
            this.TotalDurationMs = totalDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost1" /> class.
        /// </summary>
        public TimeCost1()
        {
        }
    }
}