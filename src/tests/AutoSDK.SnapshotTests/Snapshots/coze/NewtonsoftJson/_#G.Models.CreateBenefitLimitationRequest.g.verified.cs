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
        [global::Newtonsoft.Json.JsonProperty("benefit_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PropertiesBenefitInfo BenefitInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitLimitationRequest" /> class.
        /// </summary>
        /// <param name="benefitInfo"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
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