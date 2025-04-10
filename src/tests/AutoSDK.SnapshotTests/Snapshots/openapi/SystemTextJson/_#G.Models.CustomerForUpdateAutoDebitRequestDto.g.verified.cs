//HintName: G.Models.CustomerForUpdateAutoDebitRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerForUpdateAutoDebitRequestDto
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPurchaseDWallet")]
        public bool? AutoPurchaseDWallet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cappingRemaining")]
        public double? CappingRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipQuantity")]
        public int? MembershipQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForUpdateAutoDebitRequestDto" /> class.
        /// </summary>
        /// <param name="autoPurchaseDWallet">
        /// Default Value: false
        /// </param>
        /// <param name="cappingRemaining"></param>
        /// <param name="membershipQuantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerForUpdateAutoDebitRequestDto(
            bool? autoPurchaseDWallet,
            double? cappingRemaining,
            int? membershipQuantity)
        {
            this.AutoPurchaseDWallet = autoPurchaseDWallet;
            this.CappingRemaining = cappingRemaining;
            this.MembershipQuantity = membershipQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForUpdateAutoDebitRequestDto" /> class.
        /// </summary>
        public CustomerForUpdateAutoDebitRequestDto()
        {
        }
    }
}