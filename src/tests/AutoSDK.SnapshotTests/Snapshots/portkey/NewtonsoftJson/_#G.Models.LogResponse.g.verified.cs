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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public int Status { get; set; } = default!;

        /// <summary>
        /// Response headers (only present when debug logging is enabled or request failed)<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </summary>
        /// <example>{"Content-Type":"application/json"}</example>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Response body (only present when debug logging is enabled or request failed). May be redacted for certain embedding models.<br/>
        /// Example: {"id":"chatcmpl-123","object":"chat.completion","created":1677652288}
        /// </summary>
        /// <example>{"id":"chatcmpl-123","object":"chat.completion","created":1677652288}</example>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Response time in milliseconds<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::Newtonsoft.Json.JsonProperty("responseTime", Required = global::Newtonsoft.Json.Required.Always)]
        public long ResponseTime { get; set; } = default!;

        /// <summary>
        /// JSON path to the last used option in the config<br/>
        /// Example: $.config.options[0]
        /// </summary>
        /// <example>$.config.options[0]</example>
        [global::Newtonsoft.Json.JsonProperty("lastUsedOptionJsonPath", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastUsedOptionJsonPath { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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