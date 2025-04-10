//HintName: G.Models.CheckUpgradeToMembership365ResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckUpgradeToMembership365ResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CustomPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alreadyUpgraded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AlreadyUpgraded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("willUpgrade")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WillUpgrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalValueOfActiveSubscriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalValueOfActiveSubscriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredCustomPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequiredCustomPrice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUpgradeToMembership365ResponseDto" /> class.
        /// </summary>
        /// <param name="customPrice"></param>
        /// <param name="alreadyUpgraded"></param>
        /// <param name="willUpgrade"></param>
        /// <param name="totalValueOfActiveSubscriptions"></param>
        /// <param name="threshold"></param>
        /// <param name="requiredCustomPrice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckUpgradeToMembership365ResponseDto(
            double customPrice,
            bool alreadyUpgraded,
            bool willUpgrade,
            double totalValueOfActiveSubscriptions,
            double threshold,
            double requiredCustomPrice)
        {
            this.CustomPrice = customPrice;
            this.AlreadyUpgraded = alreadyUpgraded;
            this.WillUpgrade = willUpgrade;
            this.TotalValueOfActiveSubscriptions = totalValueOfActiveSubscriptions;
            this.Threshold = threshold;
            this.RequiredCustomPrice = requiredCustomPrice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUpgradeToMembership365ResponseDto" /> class.
        /// </summary>
        public CheckUpgradeToMembership365ResponseDto()
        {
        }
    }
}