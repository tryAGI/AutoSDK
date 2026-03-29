//HintName: G.Models.EstimatePricingRequestVariant2Endpoints2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant2Endpoints2
    {
        /// <summary>
        /// Number of billing units expected (e.g., number of images, videos, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant2Endpoints2" /> class.
        /// </summary>
        /// <param name="unitQuantity">
        /// Number of billing units expected (e.g., number of images, videos, etc.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant2Endpoints2(
            double unitQuantity)
        {
            this.UnitQuantity = unitQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant2Endpoints2" /> class.
        /// </summary>
        public EstimatePricingRequestVariant2Endpoints2()
        {
        }
    }
}