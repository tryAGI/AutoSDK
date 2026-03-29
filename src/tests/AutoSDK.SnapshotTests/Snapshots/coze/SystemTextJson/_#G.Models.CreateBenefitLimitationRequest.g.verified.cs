//HintName: G.Models.CreateBenefitLimitationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBenefitLimitationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PropertiesBenefitInfo BenefitInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitLimitationRequest" /> class.
        /// </summary>
        /// <param name="benefitInfo"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBenefitLimitationRequest(
            global::G.PropertiesBenefitInfo benefitInfo,
            string entityType,
            string? entityId)
        {
            this.BenefitInfo = benefitInfo ?? throw new global::System.ArgumentNullException(nameof(benefitInfo));
            this.EntityId = entityId;
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitLimitationRequest" /> class.
        /// </summary>
        public CreateBenefitLimitationRequest()
        {
        }
    }
}