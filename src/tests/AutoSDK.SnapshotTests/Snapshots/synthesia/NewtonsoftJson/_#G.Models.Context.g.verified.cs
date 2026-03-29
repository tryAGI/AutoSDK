//HintName: G.Models.Context.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event context (workspace, organization, IP address).
    /// </summary>
    public sealed partial class Context
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaceId")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="organizationId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ipAddress">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public Context(
            string? workspaceId,
            string? organizationId,
            string? ipAddress)
        {
            this.WorkspaceId = workspaceId;
            this.OrganizationId = organizationId;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        public Context()
        {
        }
    }
}