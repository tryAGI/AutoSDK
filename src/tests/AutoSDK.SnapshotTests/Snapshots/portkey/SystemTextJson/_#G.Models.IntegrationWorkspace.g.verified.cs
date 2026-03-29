//HintName: G.Models.IntegrationWorkspace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationWorkspace
    {
        /// <summary>
        /// Workspace ID<br/>
        /// Example: ws-my-team-1234
        /// </summary>
        /// <example>ws-my-team-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether the workspace has access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::System.Collections.Generic.IList<global::G.UsageLimits>? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationWorkspace" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace ID<br/>
        /// Example: ws-my-team-1234
        /// </param>
        /// <param name="enabled">
        /// Whether the workspace has access
        /// </param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationWorkspace(
            string? id,
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationWorkspace" /> class.
        /// </summary>
        public IntegrationWorkspace()
        {
        }
    }
}