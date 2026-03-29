//HintName: G.Models.TimeCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeCost
    {
        /// <summary>
        /// 耗时、ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost" /> class.
        /// </summary>
        /// <param name="totalDurationMs">
        /// 耗时、ms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeCost(
            int? totalDurationMs)
        {
            this.TotalDurationMs = totalDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeCost" /> class.
        /// </summary>
        public TimeCost()
        {
        }
    }
}