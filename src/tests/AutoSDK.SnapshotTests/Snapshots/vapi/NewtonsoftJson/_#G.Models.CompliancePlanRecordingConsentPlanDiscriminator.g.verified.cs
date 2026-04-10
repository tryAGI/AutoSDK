//HintName: G.Models.CompliancePlanRecordingConsentPlanDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompliancePlanRecordingConsentPlanDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CompliancePlanRecordingConsentPlanDiscriminatorTypeJsonConverter))]
        public global::G.CompliancePlanRecordingConsentPlanDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompliancePlanRecordingConsentPlanDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CompliancePlanRecordingConsentPlanDiscriminator(
            global::G.CompliancePlanRecordingConsentPlanDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompliancePlanRecordingConsentPlanDiscriminator" /> class.
        /// </summary>
        public CompliancePlanRecordingConsentPlanDiscriminator()
        {
        }
    }
}