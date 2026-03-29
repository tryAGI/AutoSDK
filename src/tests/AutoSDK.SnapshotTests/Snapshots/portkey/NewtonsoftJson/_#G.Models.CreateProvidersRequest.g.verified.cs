//HintName: G.Models.CreateProvidersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProvidersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Integration slug used for the provider creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationId { get; set; } = default!;

        /// <summary>
        /// optional, needed when using organisation admin API keys
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Slug for the provider. If not passed, slug will be created by adding a random suffix to the name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProvidersRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="integrationId">
        /// Integration slug used for the provider creation.
        /// </param>
        /// <param name="workspaceId">
        /// optional, needed when using organisation admin API keys
        /// </param>
        /// <param name="slug">
        /// Slug for the provider. If not passed, slug will be created by adding a random suffix to the name.
        /// </param>
        /// <param name="note"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        public CreateProvidersRequest(
            string name,
            string integrationId,
            global::System.Guid? workspaceId,
            string? slug,
            string? note,
            global::G.UsageLimits? usageLimits,
            global::G.RateLimits? rateLimits,
            global::System.DateTime? expiresAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.WorkspaceId = workspaceId;
            this.Slug = slug;
            this.Note = note;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProvidersRequest" /> class.
        /// </summary>
        public CreateProvidersRequest()
        {
        }
    }
}