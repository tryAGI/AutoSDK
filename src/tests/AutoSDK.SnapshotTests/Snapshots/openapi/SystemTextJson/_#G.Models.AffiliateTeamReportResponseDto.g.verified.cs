//HintName: G.Models.AffiliateTeamReportResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AffiliateTeamReportResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalJoined")]
        public int? TotalJoined { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateTeamReportResponseDto" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="totalJoined"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AffiliateTeamReportResponseDto(
            global::System.DateTime? date,
            int? totalJoined)
        {
            this.Date = date;
            this.TotalJoined = totalJoined;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateTeamReportResponseDto" /> class.
        /// </summary>
        public AffiliateTeamReportResponseDto()
        {
        }
    }
}