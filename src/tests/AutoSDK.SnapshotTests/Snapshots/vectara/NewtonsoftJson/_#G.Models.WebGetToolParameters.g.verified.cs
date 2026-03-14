//HintName: G.Models.WebGetToolParameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the web get tool. If not provided, will be filled in by the agent.
    /// </summary>
    public sealed partial class WebGetToolParameters
    {
        /// <summary>
        /// The URL to fetch content from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public global::G.OneOf<string, global::G.EagerReference>? Url { get; set; }

        /// <summary>
        /// HTTP method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.WebGetToolParametersMethod? Method { get; set; }

        /// <summary>
        /// HTTP headers to include in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::G.OneOf<global::System.Collections.Generic.Dictionary<string, string>, global::G.EagerReference>? Headers { get; set; }

        /// <summary>
        /// Request body for POST/PUT requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.OneOf<string, global::G.EagerReference>? Body { get; set; }

        /// <summary>
        /// Whether to follow HTTP redirects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("follow_redirects")]
        public global::G.OneOf<bool?, global::G.EagerReference>? FollowRedirects { get; set; }

        /// <summary>
        /// Request timeout in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_seconds")]
        public global::G.OneOf<int?, global::G.EagerReference>? TimeoutSeconds { get; set; }

        /// <summary>
        /// Number of lines from start to include in response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_lines")]
        public global::G.OneOf<int?, global::G.EagerReference>? HeadLines { get; set; }

        /// <summary>
        /// Number of lines from end to include in response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tail_lines")]
        public global::G.OneOf<int?, global::G.EagerReference>? TailLines { get; set; }

        /// <summary>
        /// Whether to verify SSL certificates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssl_verify")]
        public global::G.OneOf<bool?, global::G.EagerReference>? SslVerify { get; set; }

        /// <summary>
        /// Maximum response size in bytes before truncation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_content_bytes")]
        public global::G.OneOf<int?, global::G.EagerReference>? MaxContentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolParameters" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch content from.
        /// </param>
        /// <param name="method">
        /// HTTP method to use.
        /// </param>
        /// <param name="headers">
        /// HTTP headers to include in the request.
        /// </param>
        /// <param name="body">
        /// Request body for POST/PUT requests.
        /// </param>
        /// <param name="followRedirects">
        /// Whether to follow HTTP redirects.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Request timeout in seconds.
        /// </param>
        /// <param name="headLines">
        /// Number of lines from start to include in response.
        /// </param>
        /// <param name="tailLines">
        /// Number of lines from end to include in response.
        /// </param>
        /// <param name="sslVerify">
        /// Whether to verify SSL certificates.
        /// </param>
        /// <param name="maxContentBytes">
        /// Maximum response size in bytes before truncation.
        /// </param>
        public WebGetToolParameters(
            global::G.OneOf<string, global::G.EagerReference>? url,
            global::G.WebGetToolParametersMethod? method,
            global::G.OneOf<global::System.Collections.Generic.Dictionary<string, string>, global::G.EagerReference>? headers,
            global::G.OneOf<string, global::G.EagerReference>? body,
            global::G.OneOf<bool?, global::G.EagerReference>? followRedirects,
            global::G.OneOf<int?, global::G.EagerReference>? timeoutSeconds,
            global::G.OneOf<int?, global::G.EagerReference>? headLines,
            global::G.OneOf<int?, global::G.EagerReference>? tailLines,
            global::G.OneOf<bool?, global::G.EagerReference>? sslVerify,
            global::G.OneOf<int?, global::G.EagerReference>? maxContentBytes)
        {
            this.Url = url;
            this.Method = method;
            this.Headers = headers;
            this.Body = body;
            this.FollowRedirects = followRedirects;
            this.TimeoutSeconds = timeoutSeconds;
            this.HeadLines = headLines;
            this.TailLines = tailLines;
            this.SslVerify = sslVerify;
            this.MaxContentBytes = maxContentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolParameters" /> class.
        /// </summary>
        public WebGetToolParameters()
        {
        }
    }
}