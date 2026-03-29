//HintName: G.Models.CreateGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGuardrailRequest
    {
        /// <summary>
        /// Name for the new guardrail
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval?, object>))]
        public global::G.OneOf<global::G.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval?, object>? ResetInterval { get; set; }

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
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new guardrail
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
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="enforceZdr">
        /// Whether to enforce zero data retention
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRequest(
            string name,
            string? description,
            double? limitUsd,
            global::G.OneOf<global::G.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval?, object>? resetInterval,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            global::System.Collections.Generic.IList<string>? allowedModels,
            bool? enforceZdr)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
            this.AllowedProviders = allowedProviders;
            this.IgnoredProviders = ignoredProviders;
            this.AllowedModels = allowedModels;
            this.EnforceZdr = enforceZdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        public CreateGuardrailRequest()
        {
        }
    }
}