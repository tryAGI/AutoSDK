//HintName: G.Models.PostToolsExecuteProxyRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequest
    {
        /// <summary>
        /// The ID of the connected account to use for authentication (if not provided, will use the default account for the project)<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </summary>
        /// <example>ca_1a2b3c4d5e6f</example>
        [global::Newtonsoft.Json.JsonProperty("connected_account_id")]
        public string? ConnectedAccountId { get; set; }

        /// <summary>
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </summary>
        /// <example>/api/v1/resources</example>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolsExecuteProxyRequestMethod Method { get; set; } = default!;

        /// <summary>
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </summary>
        /// <example>{"name":"New Resource","description":"This is a new resource"}</example>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary_body")]
        public global::G.AnyOf<global::G.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::G.PostToolsExecuteProxyRequestBinaryBodyVariant2>? BinaryBody { get; set; }

        /// <summary>
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </summary>
        /// <example>[{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]</example>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.IList<global::G.PostToolsExecuteProxyRequestParameter>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_connection_data")]
        public global::G.OneOf<global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant1, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant2, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant3, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant4, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant5, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant6, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant7, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant9, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant10, global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant11>? CustomConnectionData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequest" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </param>
        /// <param name="connectedAccountId">
        /// The ID of the connected account to use for authentication (if not provided, will use the default account for the project)<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="body">
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </param>
        /// <param name="binaryBody">
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </param>
        /// <param name="parameters">
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </param>
        public PostToolsExecuteProxyRequest(
            string endpoint,
            global::G.PostToolsExecuteProxyRequestMethod method,
            string? connectedAccountId,
            object? body,
            global::G.AnyOf<global::G.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::G.PostToolsExecuteProxyRequestBinaryBodyVariant2>? binaryBody,
            global::System.Collections.Generic.IList<global::G.PostToolsExecuteProxyRequestParameter>? parameters)
        {
            this.ConnectedAccountId = connectedAccountId;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Method = method;
            this.Body = body;
            this.BinaryBody = binaryBody;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequest" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequest()
        {
        }
    }
}