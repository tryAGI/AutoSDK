//HintName: G.Models.PartialPropertyWithResponseV1ToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPropertyWithResponseV1ToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_key")]
        public global::G.PartialTextOperators? PropertyKey { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_value")]
        public global::G.PartialTextOperators? PropertyValue { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_created_at")]
        public global::G.PartialTimestampOperatorsTyped? RequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public global::G.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threat")]
        public global::G.PartialBooleanOperators? Threat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertyWithResponseV1ToOperators" /> class.
        /// </summary>
        /// <param name="propertyKey">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyValue">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="threat">
        /// Make all properties in T optional
        /// </param>
        public PartialPropertyWithResponseV1ToOperators(
            global::G.PartialTextOperators? propertyKey,
            global::G.PartialTextOperators? propertyValue,
            global::G.PartialTimestampOperatorsTyped? requestCreatedAt,
            global::G.PartialTextOperators? organizationId,
            global::G.PartialBooleanOperators? threat)
        {
            this.PropertyKey = propertyKey;
            this.PropertyValue = propertyValue;
            this.RequestCreatedAt = requestCreatedAt;
            this.OrganizationId = organizationId;
            this.Threat = threat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertyWithResponseV1ToOperators" /> class.
        /// </summary>
        public PartialPropertyWithResponseV1ToOperators()
        {
        }
    }
}