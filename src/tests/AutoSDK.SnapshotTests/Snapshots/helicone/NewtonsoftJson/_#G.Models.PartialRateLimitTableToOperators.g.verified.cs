//HintName: G.Models.PartialRateLimitTableToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRateLimitTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public global::G.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::G.PartialTimestampOperatorsTyped? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRateLimitTableToOperators" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        public PartialRateLimitTableToOperators(
            global::G.PartialTextOperators? organizationId,
            global::G.PartialTimestampOperatorsTyped? createdAt)
        {
            this.OrganizationId = organizationId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRateLimitTableToOperators" /> class.
        /// </summary>
        public PartialRateLimitTableToOperators()
        {
        }
    }
}