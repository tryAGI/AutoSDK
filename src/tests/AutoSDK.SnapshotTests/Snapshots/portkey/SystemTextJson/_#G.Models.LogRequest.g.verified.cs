//HintName: G.Models.LogRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogRequest
    {
        /// <summary>
        /// Sanitized request URL<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.openai.com/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// HTTP method<br/>
        /// Example: POST
        /// </summary>
        /// <example>POST</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LogRequestMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LogRequestMethod Method { get; set; }

        /// <summary>
        /// Request headers (only present when debug logging is enabled)<br/>
        /// Example: {"Content-Type":"application/json","Authorization":"Bearer hashed_value"}
        /// </summary>
        /// <example>{"Content-Type":"application/json","Authorization":"Bearer hashed_value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Request body (only present when debug logging is enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Portkey-specific headers<br/>
        /// Example: {"x-portkey-trace-id":"trace-123","x-portkey-span-id":"span-456","x-portkey-metadata":"{\u0022key\u0022:\u0022value\u0022}"}
        /// </summary>
        /// <example>{"x-portkey-trace-id":"trace-123","x-portkey-span-id":"span-456","x-portkey-metadata":"{\u0022key\u0022:\u0022value\u0022}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("portkeyHeaders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> PortkeyHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Sanitized request URL<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </param>
        /// <param name="method">
        /// HTTP method<br/>
        /// Example: POST
        /// </param>
        /// <param name="portkeyHeaders">
        /// Portkey-specific headers<br/>
        /// Example: {"x-portkey-trace-id":"trace-123","x-portkey-span-id":"span-456","x-portkey-metadata":"{\u0022key\u0022:\u0022value\u0022}"}
        /// </param>
        /// <param name="headers">
        /// Request headers (only present when debug logging is enabled)<br/>
        /// Example: {"Content-Type":"application/json","Authorization":"Bearer hashed_value"}
        /// </param>
        /// <param name="body">
        /// Request body (only present when debug logging is enabled)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogRequest(
            string url,
            global::G.LogRequestMethod method,
            global::System.Collections.Generic.Dictionary<string, string> portkeyHeaders,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? body)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
            this.Body = body;
            this.PortkeyHeaders = portkeyHeaders ?? throw new global::System.ArgumentNullException(nameof(portkeyHeaders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        public LogRequest()
        {
        }
    }
}