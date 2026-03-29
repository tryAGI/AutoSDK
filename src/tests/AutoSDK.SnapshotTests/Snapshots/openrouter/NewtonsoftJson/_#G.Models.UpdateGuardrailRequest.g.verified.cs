//HintName: G.Models.UpdateGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailRequest
    {
        /// <summary>
        /// New name for the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description for the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New spending limit in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset_interval")]
        public global::G.OneOf<global::G.GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval?, object>? ResetInterval { get; set; }

        /// <summary>
        /// New list of allowed provider IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// List of provider IDs to exclude from routing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the guardrail
        /// </param>
        /// <param name="description">
        /// New description for the guardrail
        /// </param>
        /// <param name="limitUsd">
        /// New spending limit in USD
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
        /// <param name="allowedProviders">
        /// New list of allowed provider IDs
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
        public UpdateGuardrailRequest(
            string? name,
            string? description,
            double? limitUsd,
            global::G.OneOf<global::G.GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval?, object>? resetInterval,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            global::System.Collections.Generic.IList<string>? allowedModels,
            bool? enforceZdr)
        {
            this.Name = name;
            this.Description = description;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
            this.AllowedProviders = allowedProviders;
            this.IgnoredProviders = ignoredProviders;
            this.AllowedModels = allowedModels;
            this.EnforceZdr = enforceZdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        public UpdateGuardrailRequest()
        {
        }
    }
}