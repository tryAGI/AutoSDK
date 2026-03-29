//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepLogRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseStepLogRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public string Method { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLogRequest" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="params"></param>
        /// <param name="timeout"></param>
        /// <param name="json"></param>
        public GetInternalActionExecutionLogByIdResponseStepLogRequest(
            string method,
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, object?>? @params,
            double? timeout,
            global::System.Collections.Generic.Dictionary<string, object?>? json)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Params = @params;
            this.Timeout = timeout;
            this.Json = json;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLogRequest" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseStepLogRequest()
        {
        }
    }
}