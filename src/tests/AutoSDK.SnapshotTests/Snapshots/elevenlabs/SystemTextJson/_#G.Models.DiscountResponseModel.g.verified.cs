//HintName: G.Models.DiscountResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscountResponseModel
    {
        /// <summary>
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_percent_off")]
        public double? DiscountPercentOff { get; set; }

        /// <summary>
        /// The discount applied to the invoice. E.g. [20.0f] for 20 cents off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_amount_off")]
        public double? DiscountAmountOff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountResponseModel" /> class.
        /// </summary>
        /// <param name="discountPercentOff">
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </param>
        /// <param name="discountAmountOff">
        /// The discount applied to the invoice. E.g. [20.0f] for 20 cents off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscountResponseModel(
            double? discountPercentOff,
            double? discountAmountOff)
        {
            this.DiscountPercentOff = discountPercentOff;
            this.DiscountAmountOff = discountAmountOff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountResponseModel" /> class.
        /// </summary>
        public DiscountResponseModel()
        {
        }
    }
}