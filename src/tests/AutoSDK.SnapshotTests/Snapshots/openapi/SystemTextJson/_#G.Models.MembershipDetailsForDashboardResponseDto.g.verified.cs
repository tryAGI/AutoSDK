//HintName: G.Models.MembershipDetailsForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MembershipDetailsForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipActive")]
        public double? MembershipActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipActiveMultiplied")]
        public double? MembershipActiveMultiplied { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commissionEarned")]
        public double? CommissionEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commissionRemaining")]
        public double? CommissionRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daysRemaining")]
        public int? DaysRemaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipDetailsForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="membershipActive"></param>
        /// <param name="membershipActiveMultiplied"></param>
        /// <param name="commissionEarned"></param>
        /// <param name="commissionRemaining"></param>
        /// <param name="daysRemaining"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MembershipDetailsForDashboardResponseDto(
            double? membershipActive,
            double? membershipActiveMultiplied,
            double? commissionEarned,
            double? commissionRemaining,
            int? daysRemaining)
        {
            this.MembershipActive = membershipActive;
            this.MembershipActiveMultiplied = membershipActiveMultiplied;
            this.CommissionEarned = commissionEarned;
            this.CommissionRemaining = commissionRemaining;
            this.DaysRemaining = daysRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipDetailsForDashboardResponseDto" /> class.
        /// </summary>
        public MembershipDetailsForDashboardResponseDto()
        {
        }
    }
}