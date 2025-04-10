//HintName: G.Models.LeadershipPoolDataItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LeadershipPoolDataItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leadershipPoolRankId")]
        public long? LeadershipPoolRankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leadershipPoolRankName")]
        public string? LeadershipPoolRankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentMonth")]
        public double? CurrentMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousMonth")]
        public double? PreviousMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achieved")]
        public bool? Achieved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadershipPoolDataItemDto" /> class.
        /// </summary>
        /// <param name="leadershipPoolRankId"></param>
        /// <param name="leadershipPoolRankName"></param>
        /// <param name="currentMonth"></param>
        /// <param name="previousMonth"></param>
        /// <param name="achieved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LeadershipPoolDataItemDto(
            long? leadershipPoolRankId,
            string? leadershipPoolRankName,
            double? currentMonth,
            double? previousMonth,
            bool? achieved)
        {
            this.LeadershipPoolRankId = leadershipPoolRankId;
            this.LeadershipPoolRankName = leadershipPoolRankName;
            this.CurrentMonth = currentMonth;
            this.PreviousMonth = previousMonth;
            this.Achieved = achieved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadershipPoolDataItemDto" /> class.
        /// </summary>
        public LeadershipPoolDataItemDto()
        {
        }
    }
}