//HintName: G.Models.MCPServerConfigOutput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerConfigOutput
    {
        /// <summary>
        /// Defines the MCP server-level approval policy for tool execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPApprovalPolicyJsonConverter))]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_approval_hashes")]
        public global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? ToolApprovalHashes { get; set; }

        /// <summary>
        /// Supported MCP server transport types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPServerTransportJsonConverter))]
        public global::G.MCPServerTransport? Transport { get; set; }

        /// <summary>
        /// The URL of the MCP server, if this contains a secret please store as a workspace secret, otherwise store as a plain string. Must use https
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::G.ConvAISecretLocator> Url { get; set; }

        /// <summary>
        /// The secret token (Authorization header) stored as a workspace secret or in-place secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel>))]
        public global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel>? SecretToken { get; set; }

        /// <summary>
        /// The headers included in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigOutput" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.
        /// </param>
        /// <param name="toolApprovalHashes">
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </param>
        /// <param name="transport">
        /// Supported MCP server transport types.
        /// </param>
        /// <param name="url">
        /// The URL of the MCP server, if this contains a secret please store as a workspace secret, otherwise store as a plain string. Must use https
        /// </param>
        /// <param name="secretToken">
        /// The secret token (Authorization header) stored as a workspace secret or in-place secret
        /// </param>
        /// <param name="requestHeaders">
        /// The headers included in the request
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerConfigOutput(
            global::G.AnyOf<string, global::G.ConvAISecretLocator> url,
            string name,
            global::G.MCPApprovalPolicy? approvalPolicy,
            global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? toolApprovalHashes,
            global::G.MCPServerTransport? transport,
            global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel>? secretToken,
            object? requestHeaders,
            string? description)
        {
            this.Url = url;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApprovalPolicy = approvalPolicy;
            this.ToolApprovalHashes = toolApprovalHashes;
            this.Transport = transport;
            this.SecretToken = secretToken;
            this.RequestHeaders = requestHeaders;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigOutput" /> class.
        /// </summary>
        public MCPServerConfigOutput()
        {
        }
    }
}