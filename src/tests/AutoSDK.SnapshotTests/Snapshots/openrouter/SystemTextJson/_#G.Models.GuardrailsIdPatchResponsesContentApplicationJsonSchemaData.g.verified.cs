//HintName: G.Models.GuardrailsIdPatchResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The updated guardrail
    /// </summary>
    public sealed partial class GuardrailsIdPatchResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Unique identifier for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Spending limit in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval?, object>))]
        public global::G.OneOf<global::G.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval?, object>? ResetInterval { get; set; }

        /// <summary>
        /// List of allowed provider IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// List of provider IDs to exclude from routing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        /// Array of model canonical_slugs (immutable identifiers)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the guardrail was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the guardrail was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdPatchResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the guardrail
        /// </param>
        /// <param name="name">
        /// Name of the guardrail
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the guardrail was created
        /// </param>
        /// <param name="description">
        /// Description of the guardrail
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing
        /// </param>
        /// <param name="allowedModels">
        /// Array of model canonical_slugs (immutable identifiers)
        /// </param>
        /// <param name="enforceZdr">
        /// Whether to enforce zero data retention
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the guardrail was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsIdPatchResponsesContentApplicationJsonSchemaData(
            global::System.Guid id,
            string name,
            string createdAt,
            string? description,
            double? limitUsd,
            global::G.OneOf<global::G.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval?, object>? resetInterval,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            global::System.Collections.Generic.IList<string>? allowedModels,
            bool? enforceZdr,
            string? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
            this.AllowedProviders = allowedProviders;
            this.IgnoredProviders = ignoredProviders;
            this.AllowedModels = allowedModels;
            this.EnforceZdr = enforceZdr;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdPatchResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public GuardrailsIdPatchResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}