//HintName: G.Models.ProductSubscriptionForChangeAutoRenewOptionRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForChangeAutoRenewOptionRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productSubscriptionId")]
        public long? ProductSubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForChangeAutoRenewOptionRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productSubscriptionId"></param>
        /// <param name="autoRenew"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForChangeAutoRenewOptionRequestDto(
            long? userId,
            long? productSubscriptionId,
            bool? autoRenew)
        {
            this.UserId = userId;
            this.ProductSubscriptionId = productSubscriptionId;
            this.AutoRenew = autoRenew;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForChangeAutoRenewOptionRequestDto" /> class.
        /// </summary>
        public ProductSubscriptionForChangeAutoRenewOptionRequestDto()
        {
        }
    }
}