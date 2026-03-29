//HintName: G.Models.PartialOrganizationPropertiesToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialOrganizationPropertiesToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::G.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_key")]
        public global::G.PartialTextOperators? PropertyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialOrganizationPropertiesToOperators" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyKey">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialOrganizationPropertiesToOperators(
            global::G.PartialTextOperators? organizationId,
            global::G.PartialTextOperators? propertyKey)
        {
            this.OrganizationId = organizationId;
            this.PropertyKey = propertyKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialOrganizationPropertiesToOperators" /> class.
        /// </summary>
        public PartialOrganizationPropertiesToOperators()
        {
        }
    }
}