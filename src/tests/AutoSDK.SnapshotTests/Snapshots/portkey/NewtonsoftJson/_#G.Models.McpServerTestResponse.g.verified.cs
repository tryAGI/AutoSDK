//HintName: G.Models.McpServerTestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerTestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// HTTP status from upstream (when success)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_time_ms")]
        public int? ResponseTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// Error message when success is false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTestResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="statusCode">
        /// HTTP status from upstream (when success)
        /// </param>
        /// <param name="responseTimeMs"></param>
        /// <param name="url"></param>
        /// <param name="serverName"></param>
        /// <param name="error">
        /// Error message when success is false
        /// </param>
        public McpServerTestResponse(
            bool? success,
            int? statusCode,
            int? responseTimeMs,
            string? url,
            string? serverName,
            string? error)
        {
            this.Success = success;
            this.StatusCode = statusCode;
            this.ResponseTimeMs = responseTimeMs;
            this.Url = url;
            this.ServerName = serverName;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTestResponse" /> class.
        /// </summary>
        public McpServerTestResponse()
        {
        }
    }
}