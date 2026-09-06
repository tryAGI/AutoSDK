//HintName: G.Models.MCPToolHealth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Health status for an MCP tool's schema.
    /// </summary>
    public sealed partial class MCPToolHealth
    {
        /// <summary>
        /// Schema health status: STRICT_COMPLIANT, NON_STRICT_ONLY, or INVALID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// List of reasons for the health status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasons")]
        public global::System.Collections.Generic.IList<string>? Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolHealth" /> class.
        /// </summary>
        /// <param name="status">
        /// Schema health status: STRICT_COMPLIANT, NON_STRICT_ONLY, or INVALID
        /// </param>
        /// <param name="reasons">
        /// List of reasons for the health status
        /// </param>
        public MCPToolHealth(
            string status,
            global::System.Collections.Generic.IList<string>? reasons)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Reasons = reasons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolHealth" /> class.
        /// </summary>
        public MCPToolHealth()
        {
        }

    }
}