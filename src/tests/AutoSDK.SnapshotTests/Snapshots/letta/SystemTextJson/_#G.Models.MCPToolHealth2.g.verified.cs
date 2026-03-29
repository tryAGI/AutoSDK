//HintName: G.Models.MCPToolHealth2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Health status for an MCP tool's schema.
    /// </summary>
    public sealed partial class MCPToolHealth2
    {
        /// <summary>
        /// Schema health status: STRICT_COMPLIANT, NON_STRICT_ONLY, or INVALID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// List of reasons for the health status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<string>? Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolHealth2" /> class.
        /// </summary>
        /// <param name="status">
        /// Schema health status: STRICT_COMPLIANT, NON_STRICT_ONLY, or INVALID
        /// </param>
        /// <param name="reasons">
        /// List of reasons for the health status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolHealth2(
            string status,
            global::System.Collections.Generic.IList<string>? reasons)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Reasons = reasons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolHealth2" /> class.
        /// </summary>
        public MCPToolHealth2()
        {
        }
    }
}