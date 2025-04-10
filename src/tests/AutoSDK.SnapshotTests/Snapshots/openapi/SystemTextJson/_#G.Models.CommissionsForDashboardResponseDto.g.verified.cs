//HintName: G.Models.CommissionsForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommissionsForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyCommissions")]
        public double? DailyCommissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCommissions")]
        public double? TotalCommissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionsForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="dailyCommissions"></param>
        /// <param name="totalCommissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommissionsForDashboardResponseDto(
            double? dailyCommissions,
            double? totalCommissions)
        {
            this.DailyCommissions = dailyCommissions;
            this.TotalCommissions = totalCommissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionsForDashboardResponseDto" /> class.
        /// </summary>
        public CommissionsForDashboardResponseDto()
        {
        }
    }
}