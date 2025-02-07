//HintName: G.Models.SubtractCreditAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SubtractCreditResponse contains the remaining credit of an account after the<br/>
    /// subtraction.
    /// </summary>
    public sealed partial class SubtractCreditAdminResponse
    {
        /// <summary>
        /// The remaining credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public float? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtractCreditAdminResponse" /> class.
        /// </summary>
        /// <param name="amount">
        /// The remaining credit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubtractCreditAdminResponse(
            float? amount)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtractCreditAdminResponse" /> class.
        /// </summary>
        public SubtractCreditAdminResponse()
        {
        }
    }
}