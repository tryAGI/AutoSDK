//HintName: G.Models.PostToolsExecuteProxyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyResponse
    {
        /// <summary>
        /// The response data returned from the proxied API<br/>
        /// Example: {"id":"123","name":"Resource Name","created_at":"2023-01-01T00:00:00Z"}
        /// </summary>
        /// <example>{"id":"123","name":"Resource Name","created_at":"2023-01-01T00:00:00Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Binary body response data. Present when the response is a binary file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_data")]
        public global::G.PostToolsExecuteProxyResponseBinaryData? BinaryData { get; set; }

        /// <summary>
        /// The HTTP status code returned from the proxied API<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// The HTTP headers returned from the proxied API<br/>
        /// Example: {"content-type":"application/json","cache-control":"no-cache","host":"api.example.com"}
        /// </summary>
        /// <example>{"content-type":"application/json","cache-control":"no-cache","host":"api.example.com"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The HTTP status code returned from the proxied API<br/>
        /// Example: 200
        /// </param>
        /// <param name="data">
        /// The response data returned from the proxied API<br/>
        /// Example: {"id":"123","name":"Resource Name","created_at":"2023-01-01T00:00:00Z"}
        /// </param>
        /// <param name="binaryData">
        /// Binary body response data. Present when the response is a binary file.
        /// </param>
        /// <param name="headers">
        /// The HTTP headers returned from the proxied API<br/>
        /// Example: {"content-type":"application/json","cache-control":"no-cache","host":"api.example.com"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteProxyResponse(
            double status,
            object? data,
            global::G.PostToolsExecuteProxyResponseBinaryData? binaryData,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Data = data;
            this.BinaryData = binaryData;
            this.Status = status;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyResponse" /> class.
        /// </summary>
        public PostToolsExecuteProxyResponse()
        {
        }
    }
}