//HintName: G.Models.GlobalWorkspaceAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalWorkspaceAccess
    {
        /// <summary>
        /// Whether global workspace access is enabled. When enabled, the integration will be enabled for all workspaces that are created in future.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalWorkspaceAccess" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether global workspace access is enabled. When enabled, the integration will be enabled for all workspaces that are created in future.
        /// </param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        public GlobalWorkspaceAccess(
            bool enabled,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits)
        {
            this.Enabled = enabled;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalWorkspaceAccess" /> class.
        /// </summary>
        public GlobalWorkspaceAccess()
        {
        }
    }
}