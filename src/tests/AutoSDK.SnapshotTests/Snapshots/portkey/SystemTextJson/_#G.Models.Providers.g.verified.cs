//HintName: G.Models.Providers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Providers
    {
        /// <summary>
        /// Example: Open AI Workspace
        /// </summary>
        /// <example>Open AI Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public string? IntegrationId { get; set; }

        /// <summary>
        /// Example: randomness
        /// </summary>
        /// <example>randomness</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProvidersStatusJsonConverter))]
        public global::G.ProvidersStatus? Status { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_usage")]
        public double? ResetUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProvidersObjectJsonConverter))]
        public global::G.ProvidersObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Providers" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Open AI Workspace
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="note">
        /// Example: randomness
        /// </param>
        /// <param name="status"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="resetUsage">
        /// Example: 0
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="slug"></param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Providers(
            string? name,
            string? integrationId,
            string? note,
            global::G.ProvidersStatus? status,
            global::G.UsageLimits? usageLimits,
            double? resetUsage,
            global::System.DateTime? createdAt,
            string? slug,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits,
            global::System.DateTime? expiresAt,
            global::G.ProvidersObject? @object)
        {
            this.Name = name;
            this.IntegrationId = integrationId;
            this.Note = note;
            this.Status = status;
            this.UsageLimits = usageLimits;
            this.ResetUsage = resetUsage;
            this.CreatedAt = createdAt;
            this.Slug = slug;
            this.RateLimits = rateLimits;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Providers" /> class.
        /// </summary>
        public Providers()
        {
        }
    }
}