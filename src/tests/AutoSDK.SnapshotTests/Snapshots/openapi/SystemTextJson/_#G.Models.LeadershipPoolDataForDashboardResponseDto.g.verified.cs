//HintName: G.Models.LeadershipPoolDataForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LeadershipPoolDataForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leadershipPools")]
        public global::System.Collections.Generic.IList<global::G.LeadershipPoolDataItemDto>? LeadershipPools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadershipPoolDataForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="leadershipPools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LeadershipPoolDataForDashboardResponseDto(
            global::System.Collections.Generic.IList<global::G.LeadershipPoolDataItemDto>? leadershipPools)
        {
            this.LeadershipPools = leadershipPools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadershipPoolDataForDashboardResponseDto" /> class.
        /// </summary>
        public LeadershipPoolDataForDashboardResponseDto()
        {
        }
    }
}