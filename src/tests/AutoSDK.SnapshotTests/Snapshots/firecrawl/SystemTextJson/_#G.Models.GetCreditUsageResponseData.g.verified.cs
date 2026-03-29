//HintName: G.Models.GetCreditUsageResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCreditUsageResponseData
    {
        /// <summary>
        /// Number of credits remaining for the team<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_credits")]
        public double? RemainingCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditUsageResponseData" /> class.
        /// </summary>
        /// <param name="remainingCredits">
        /// Number of credits remaining for the team<br/>
        /// Example: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCreditUsageResponseData(
            double? remainingCredits)
        {
            this.RemainingCredits = remainingCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditUsageResponseData" /> class.
        /// </summary>
        public GetCreditUsageResponseData()
        {
        }
    }
}