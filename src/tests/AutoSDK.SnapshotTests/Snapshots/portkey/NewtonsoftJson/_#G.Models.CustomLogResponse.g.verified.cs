//HintName: G.Models.CustomLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public object Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_time")]
        public int? ResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogResponse" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="status"></param>
        /// <param name="headers"></param>
        /// <param name="responseTime"></param>
        public CustomLogResponse(
            object body,
            int? status,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? responseTime)
        {
            this.Status = status;
            this.Headers = headers;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogResponse" /> class.
        /// </summary>
        public CustomLogResponse()
        {
        }
    }
}