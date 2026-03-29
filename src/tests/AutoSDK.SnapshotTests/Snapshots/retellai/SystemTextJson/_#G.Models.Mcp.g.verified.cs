//HintName: G.Models.Mcp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Mcp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The URL of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Headers to add to the MCP connection request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </summary>
        /// <example>{"Authorization":"Bearer 1234567890"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Query parameters to append to the  MCP connection request URL.<br/>
        /// Example: {"index":"1","key":"value"}
        /// </summary>
        /// <example>{"index":"1","key":"value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? QueryParams { get; set; }

        /// <summary>
        /// Maximum time to wait for a connection to be established (in milliseconds). Default to 120,000 ms (2 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mcp" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="headers">
        /// Headers to add to the MCP connection request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </param>
        /// <param name="queryParams">
        /// Query parameters to append to the  MCP connection request URL.<br/>
        /// Example: {"index":"1","key":"value"}
        /// </param>
        /// <param name="timeoutMs">
        /// Maximum time to wait for a connection to be established (in milliseconds). Default to 120,000 ms (2 minutes).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mcp(
            string name,
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? queryParams,
            int? timeoutMs)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.QueryParams = queryParams;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mcp" /> class.
        /// </summary>
        public Mcp()
        {
        }
    }
}