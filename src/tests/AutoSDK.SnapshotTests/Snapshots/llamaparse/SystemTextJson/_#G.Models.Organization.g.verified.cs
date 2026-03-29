//HintName: G.Models.Organization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an organization.
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A name for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// [Deprecated] Whether the organization is a Parse Premium customer.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_plan_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ParsePlanLevelJsonConverter))]
        public global::G.ParsePlanLevel? ParsePlanLevel { get; set; }

        /// <summary>
        /// The Stripe customer ID for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_customer_id")]
        public string? StripeCustomerId { get; set; }

        /// <summary>
        /// Feature flags for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_flags")]
        public object? FeatureFlags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name">
        /// A name for the organization.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="parsePlanLevel">
        /// [Deprecated] Whether the organization is a Parse Premium customer.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="stripeCustomerId">
        /// The Stripe customer ID for the organization.
        /// </param>
        /// <param name="featureFlags">
        /// Feature flags for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            global::System.Guid id,
            string name,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.ParsePlanLevel? parsePlanLevel,
            string? stripeCustomerId,
            object? featureFlags)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParsePlanLevel = parsePlanLevel;
            this.StripeCustomerId = stripeCustomerId;
            this.FeatureFlags = featureFlags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}