//HintName: G.Models.FundWithdrawalRequestBulkApproveResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundWithdrawalRequestBulkApproveResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfullyApproved")]
        public int? SuccessfullyApproved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfullyDonated")]
        public int? SuccessfullyDonated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("donationErrors")]
        public int? DonationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestBulkApproveResponseDto" /> class.
        /// </summary>
        /// <param name="successfullyApproved"></param>
        /// <param name="successfullyDonated"></param>
        /// <param name="donationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundWithdrawalRequestBulkApproveResponseDto(
            int? successfullyApproved,
            int? successfullyDonated,
            int? donationErrors)
        {
            this.SuccessfullyApproved = successfullyApproved;
            this.SuccessfullyDonated = successfullyDonated;
            this.DonationErrors = donationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestBulkApproveResponseDto" /> class.
        /// </summary>
        public FundWithdrawalRequestBulkApproveResponseDto()
        {
        }
    }
}