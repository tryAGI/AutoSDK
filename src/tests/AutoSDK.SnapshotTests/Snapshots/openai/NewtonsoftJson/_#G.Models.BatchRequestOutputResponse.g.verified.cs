//HintName: G.Models.BatchRequestOutputResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRequestOutputResponse
    {
        /// <summary>
        /// The HTTP status code of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// An unique identifier for the OpenAI API request. Please include this request ID when contacting support.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The JSON body of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutputResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// The HTTP status code of the response
        /// </param>
        /// <param name="requestId">
        /// An unique identifier for the OpenAI API request. Please include this request ID when contacting support.
        /// </param>
        /// <param name="body">
        /// The JSON body of the response
        /// </param>
        public BatchRequestOutputResponse(
            int? statusCode,
            string? requestId,
            object? body)
        {
            this.StatusCode = statusCode;
            this.RequestId = requestId;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutputResponse" /> class.
        /// </summary>
        public BatchRequestOutputResponse()
        {
        }
    }
}