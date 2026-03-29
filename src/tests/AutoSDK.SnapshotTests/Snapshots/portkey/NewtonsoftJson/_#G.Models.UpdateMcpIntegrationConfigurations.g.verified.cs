//HintName: G.Models.UpdateMcpIntegrationConfigurations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auth/config key-value pairs (e.g. headers, client credentials)
    /// </summary>
    public sealed partial class UpdateMcpIntegrationConfigurations
    {
        /// <summary>
        /// Custom headers to send to the MCP server.<br/>
        /// Example: {"Authorization":"Bearer some-token","x-foo":"bar"}
        /// </summary>
        /// <example>{"Authorization":"Bearer some-token","x-foo":"bar"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_headers")]
        public object? CustomHeaders { get; set; }

        /// <summary>
        /// Headers to pass through from the incoming request to the MCP server.<br/>
        /// Example: {"x-user-id":{"type":"string","example":"abc123"},"x-request-id":{"type":"string","example":"req-0001"}}
        /// </summary>
        /// <example>{"x-user-id":{"type":"string","example":"abc123"},"x-request-id":{"type":"string","example":"req-0001"}}</example>
        [global::Newtonsoft.Json.JsonProperty("passthrough_header")]
        public object? PassthroughHeader { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpIntegrationConfigurations" /> class.
        /// </summary>
        /// <param name="customHeaders">
        /// Custom headers to send to the MCP server.<br/>
        /// Example: {"Authorization":"Bearer some-token","x-foo":"bar"}
        /// </param>
        /// <param name="passthroughHeader">
        /// Headers to pass through from the incoming request to the MCP server.<br/>
        /// Example: {"x-user-id":{"type":"string","example":"abc123"},"x-request-id":{"type":"string","example":"req-0001"}}
        /// </param>
        public UpdateMcpIntegrationConfigurations(
            object? customHeaders,
            object? passthroughHeader)
        {
            this.CustomHeaders = customHeaders;
            this.PassthroughHeader = passthroughHeader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpIntegrationConfigurations" /> class.
        /// </summary>
        public UpdateMcpIntegrationConfigurations()
        {
        }
    }
}