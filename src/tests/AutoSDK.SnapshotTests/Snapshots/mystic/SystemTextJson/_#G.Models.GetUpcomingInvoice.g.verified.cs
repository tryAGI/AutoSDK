//HintName: G.Models.GetUpcomingInvoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a customer's upcoming invoice, including free credit usage in<br/>
    /// cents and billing period
    /// </summary>
    public sealed partial class GetUpcomingInvoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUpcomingInvoice" /> class.
        /// </summary>
        /// <param name="creditsUsed"></param>
        /// <param name="creditsTotal"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUpcomingInvoice(
            int creditsUsed,
            int creditsTotal,
            global::System.DateTime startDate,
            global::System.DateTime endDate)
        {
            this.CreditsUsed = creditsUsed;
            this.CreditsTotal = creditsTotal;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUpcomingInvoice" /> class.
        /// </summary>
        public GetUpcomingInvoice()
        {
        }
    }
}