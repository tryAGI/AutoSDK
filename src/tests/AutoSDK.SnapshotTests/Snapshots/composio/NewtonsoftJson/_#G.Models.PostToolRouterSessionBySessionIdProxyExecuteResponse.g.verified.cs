//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteResponse
    {
        /// <summary>
        /// The response data returned from the proxied API<br/>
        /// Example: {"id":"123","name":"Resource Name","created_at":"2023-01-01T00:00:00Z"}
        /// </summary>
        /// <example>{"id":"123","name":"Resource Name","created_at":"2023-01-01T00:00:00Z"}</example>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Binary body response data. Present when the response is a binary file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary_data")]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteResponseBinaryData? BinaryData { get; set; }

        /// <summary>
        /// The HTTP status code returned from the proxied API<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public double Status { get; set; } = default!;

        /// <summary>
        /// The HTTP headers returned from the proxied API<br/>
        /// Example: {"content-type":"application/json","cache-control":"no-cache"}
        /// </summary>
        /// <example>{"content-type":"application/json","cache-control":"no-cache"}</example>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteResponse" /> class.
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
        /// Example: {"content-type":"application/json","cache-control":"no-cache"}
        /// </param>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(
            double status,
            object? data,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteResponseBinaryData? binaryData,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Data = data;
            this.BinaryData = binaryData;
            this.Status = status;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse()
        {
        }
    }
}