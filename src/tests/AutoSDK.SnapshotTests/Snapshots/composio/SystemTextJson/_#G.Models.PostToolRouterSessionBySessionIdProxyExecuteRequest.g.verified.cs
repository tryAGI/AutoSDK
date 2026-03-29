//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequest
    {
        /// <summary>
        /// The slug of the toolkit to use for the request<br/>
        /// Example: gmail
        /// </summary>
        /// <example>gmail</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </summary>
        /// <example>/api/v1/resources</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod Method { get; set; }

        /// <summary>
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </summary>
        /// <example>{"name":"New Resource","description":"This is a new resource"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>))]
        public global::G.AnyOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>? BinaryBody { get; set; }

        /// <summary>
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </summary>
        /// <example>[{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_connection_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>))]
        public global::G.OneOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>? CustomConnectionData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequest" /> class.
        /// </summary>
        /// <param name="toolkitSlug">
        /// The slug of the toolkit to use for the request<br/>
        /// Example: gmail
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the request<br/>
        /// Example: GET
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
        /// <param name="customConnectionData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdProxyExecuteRequest(
            string toolkitSlug,
            string endpoint,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod method,
            object? body,
            global::G.AnyOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>? binaryBody,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? parameters,
            global::G.OneOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>? customConnectionData)
        {
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Method = method;
            this.Body = body;
            this.BinaryBody = binaryBody;
            this.Parameters = parameters;
            this.CustomConnectionData = customConnectionData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequest()
        {
        }
    }
}