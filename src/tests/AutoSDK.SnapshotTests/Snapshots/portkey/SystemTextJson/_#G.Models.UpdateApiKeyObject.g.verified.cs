//HintName: G.Models.UpdateApiKeyObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiKeyObject
    {
        /// <summary>
        /// Example: Development API Key
        /// </summary>
        /// <example>Development API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: API key for development environment
        /// </summary>
        /// <example>API key for development environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.UpdateApiKeyObjectRateLimit>? RateLimits { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: [completions.write]
        /// </summary>
        /// <example>[completions.write]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::G.UpdateApiKeyObjectDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_emails")]
        public global::System.Collections.Generic.IList<string>? AlertEmails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObject" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyObject(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.UpdateApiKeyObjectRateLimit>? rateLimits,
            global::G.UsageLimits? usageLimits,
            global::System.Collections.Generic.IList<string>? scopes,
            global::G.UpdateApiKeyObjectDefaults? defaults,
            global::System.Collections.Generic.IList<string>? alertEmails)
        {
            this.Name = name;
            this.Description = description;
            this.RateLimits = rateLimits;
            this.UsageLimits = usageLimits;
            this.Scopes = scopes;
            this.Defaults = defaults;
            this.AlertEmails = alertEmails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObject" /> class.
        /// </summary>
        public UpdateApiKeyObject()
        {
        }
    }
}