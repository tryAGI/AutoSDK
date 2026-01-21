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
        /// Defines the MCP server-level approval policy for tool execution.<br/>
        /// Default Value: require_approval_all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_approval_hashes")]
        public global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? ToolApprovalHashes { get; set; }

        /// <summary>
        /// The transport type used to connect to the MCP server<br/>
        /// Default Value: SSE
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.MCPServerTransport? Transport { get; set; }

        /// <summary>
        /// The URL of the MCP server, if this contains a secret please store as a workspace secret, otherwise store as a plain string. Must use https
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.ConvAISecretLocator> Url { get; set; } = default!;

        /// <summary>
        /// The secret token (Authorization header) stored as a workspace secret or in-place secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_token")]
        public global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>? SecretToken { get; set; }

        /// <summary>
        /// The headers included in the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigOutput" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.<br/>
        /// Default Value: require_approval_all
        /// </param>
        /// <param name="toolApprovalHashes">
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </param>
        /// <param name="transport">
        /// The transport type used to connect to the MCP server<br/>
        /// Default Value: SSE
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
        public MCPServerConfigOutput(
            global::G.AnyOf<string, global::G.ConvAISecretLocator> url,
            string name,
            global::G.MCPApprovalPolicy? approvalPolicy,
            global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? toolApprovalHashes,
            global::G.MCPServerTransport? transport,
            global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>? secretToken,
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