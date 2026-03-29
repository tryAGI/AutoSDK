//HintName: G.Models.LogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogResponse
    {
        /// <summary>
        /// HTTP response status code<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        /// Response headers (only present when debug logging is enabled or request failed)<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </summary>
        /// <example>{"Content-Type":"application/json"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Response body (only present when debug logging is enabled or request failed). May be redacted for certain embedding models.<br/>
        /// Example: {"id":"chatcmpl-123","object":"chat.completion","created":1677652288}
        /// </summary>
        /// <example>{"id":"chatcmpl-123","object":"chat.completion","created":1677652288}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Response time in milliseconds<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ResponseTime { get; set; }

        /// <summary>
        /// JSON path to the last used option in the config<br/>
        /// Example: $.config.options[0]
        /// </summary>
        /// <example>$.config.options[0]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedOptionJsonPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUsedOptionJsonPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// HTTP response status code<br/>
        /// Example: 200
        /// </param>
        /// <param name="responseTime">
        /// Response time in milliseconds<br/>
        /// Example: 1234
        /// </param>
        /// <param name="lastUsedOptionJsonPath">
        /// JSON path to the last used option in the config<br/>
        /// Example: $.config.options[0]
        /// </param>
        /// <param name="headers">
        /// Response headers (only present when debug logging is enabled or request failed)<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </param>
        /// <param name="body">
        /// Response body (only present when debug logging is enabled or request failed). May be redacted for certain embedding models.<br/>
        /// Example: {"id":"chatcmpl-123","object":"chat.completion","created":1677652288}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogResponse(
            int status,
            long responseTime,
            string lastUsedOptionJsonPath,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? body)
        {
            this.Status = status;
            this.Headers = headers;
            this.Body = body;
            this.ResponseTime = responseTime;
            this.LastUsedOptionJsonPath = lastUsedOptionJsonPath ?? throw new global::System.ArgumentNullException(nameof(lastUsedOptionJsonPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogResponse" /> class.
        /// </summary>
        public LogResponse()
        {
        }
    }
}