//HintName: G.Models.PutAdminWorkspacesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"name":"My Workspace","description":"My Description","defaults":{"metadata":{"foo":"bar"}}}
    /// </summary>
    public sealed partial class PutAdminWorkspacesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::G.PutAdminWorkspacesRequestDefaults? Defaults { get; set; }

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
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaults"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAdminWorkspacesRequest(
            string? name,
            string? description,
            global::G.PutAdminWorkspacesRequestDefaults? defaults,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits)
        {
            this.Name = name;
            this.Description = description;
            this.Defaults = defaults;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesRequest" /> class.
        /// </summary>
        public PutAdminWorkspacesRequest()
        {
        }
    }
}