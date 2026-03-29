//HintName: G.Models.ResourcePackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourcePackage
    {
        /// <summary>
        /// Name of the resource package.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_pack_name")]
        public string? ResourcePackName { get; set; }

        /// <summary>
        /// Unique resource package ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_pack_id")]
        public string? ResourcePackId { get; set; }

        /// <summary>
        /// Type of the resource package.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_pack_type")]
        public string? ResourcePackType { get; set; }

        /// <summary>
        /// Total quantity of credits in the package.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
        public double? TotalQuantity { get; set; }

        /// <summary>
        /// Remaining quantity of credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_quantity")]
        public double? RemainingQuantity { get; set; }

        /// <summary>
        /// Purchase timestamp (Unix milliseconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_time")]
        public long? PurchaseTime { get; set; }

        /// <summary>
        /// Effective start timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_time")]
        public long? EffectiveTime { get; set; }

        /// <summary>
        /// Expiration timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_time")]
        public long? InvalidTime { get; set; }

        /// <summary>
        /// Status of the resource package.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePackage" /> class.
        /// </summary>
        /// <param name="resourcePackName">
        /// Name of the resource package.
        /// </param>
        /// <param name="resourcePackId">
        /// Unique resource package ID.
        /// </param>
        /// <param name="resourcePackType">
        /// Type of the resource package.
        /// </param>
        /// <param name="totalQuantity">
        /// Total quantity of credits in the package.
        /// </param>
        /// <param name="remainingQuantity">
        /// Remaining quantity of credits.
        /// </param>
        /// <param name="purchaseTime">
        /// Purchase timestamp (Unix milliseconds).
        /// </param>
        /// <param name="effectiveTime">
        /// Effective start timestamp.
        /// </param>
        /// <param name="invalidTime">
        /// Expiration timestamp.
        /// </param>
        /// <param name="status">
        /// Status of the resource package.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourcePackage(
            string? resourcePackName,
            string? resourcePackId,
            string? resourcePackType,
            double? totalQuantity,
            double? remainingQuantity,
            long? purchaseTime,
            long? effectiveTime,
            long? invalidTime,
            string? status)
        {
            this.ResourcePackName = resourcePackName;
            this.ResourcePackId = resourcePackId;
            this.ResourcePackType = resourcePackType;
            this.TotalQuantity = totalQuantity;
            this.RemainingQuantity = remainingQuantity;
            this.PurchaseTime = purchaseTime;
            this.EffectiveTime = effectiveTime;
            this.InvalidTime = invalidTime;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePackage" /> class.
        /// </summary>
        public ResourcePackage()
        {
        }
    }
}