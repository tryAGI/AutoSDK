//HintName: G.Models.GetRemainingCreditAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetRemainingCreditAdminResponse contains the remaining credit of a user or<br/>
    /// organization.
    /// </summary>
    public sealed partial class GetRemainingCreditAdminResponse
    {
        /// <summary>
        /// The requested credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public float? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRemainingCreditAdminResponse" /> class.
        /// </summary>
        /// <param name="amount">
        /// The requested credit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRemainingCreditAdminResponse(
            float? amount)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRemainingCreditAdminResponse" /> class.
        /// </summary>
        public GetRemainingCreditAdminResponse()
        {
        }
    }
}