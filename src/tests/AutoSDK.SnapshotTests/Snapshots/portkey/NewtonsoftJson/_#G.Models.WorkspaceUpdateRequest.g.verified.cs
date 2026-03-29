//HintName: G.Models.WorkspaceUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceUpdateRequest
    {
        /// <summary>
        /// Workspace ID<br/>
        /// Example: ws-my-team-1234
        /// </summary>
        /// <example>ws-my-team-1234</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether to enable workspace access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::System.Collections.Generic.IList<global::G.UsageLimits>? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// Whether to reset current usage. If the current status is exhausted, this will change it back to active.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset_usage")]
        public bool? ResetUsage { get; set; }

        /// <summary>
        /// Whether to automatically create a default provider for this workspace. Overrides the top-level create_default_provider setting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_default_provider")]
        public bool? CreateDefaultProvider { get; set; }

        /// <summary>
        /// Custom slug for the auto-created default provider for this workspace. Overrides the top-level default_provider_slug. If the slug already exists, the request will fail with a validation error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_provider_slug")]
        public string? DefaultProviderSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUpdateRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace ID<br/>
        /// Example: ws-my-team-1234
        /// </param>
        /// <param name="enabled">
        /// Whether to enable workspace access
        /// </param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        /// <param name="resetUsage">
        /// Whether to reset current usage. If the current status is exhausted, this will change it back to active.
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider for this workspace. Overrides the top-level create_default_provider setting.
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider for this workspace. Overrides the top-level default_provider_slug. If the slug already exists, the request will fail with a validation error.
        /// </param>
        public WorkspaceUpdateRequest(
            string id,
            bool enabled,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits,
            bool? resetUsage,
            bool? createDefaultProvider,
            string? defaultProviderSlug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Enabled = enabled;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
            this.ResetUsage = resetUsage;
            this.CreateDefaultProvider = createDefaultProvider;
            this.DefaultProviderSlug = defaultProviderSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUpdateRequest" /> class.
        /// </summary>
        public WorkspaceUpdateRequest()
        {
        }
    }
}