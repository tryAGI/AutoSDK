//HintName: G.Models.ProductSubscriptionForUpdateCompoundingStatusRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForUpdateCompoundingStatusRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compoundingStatusEnumId")]
        public int? CompoundingStatusEnumId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForUpdateCompoundingStatusRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="compoundingStatusEnumId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForUpdateCompoundingStatusRequestDto(
            long? id,
            int? compoundingStatusEnumId)
        {
            this.Id = id;
            this.CompoundingStatusEnumId = compoundingStatusEnumId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForUpdateCompoundingStatusRequestDto" /> class.
        /// </summary>
        public ProductSubscriptionForUpdateCompoundingStatusRequestDto()
        {
        }
    }
}