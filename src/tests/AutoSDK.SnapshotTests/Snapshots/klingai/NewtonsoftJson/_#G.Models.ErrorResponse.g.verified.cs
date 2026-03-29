//HintName: G.Models.ErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique request ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code.
        /// </param>
        /// <param name="message">
        /// Error message.
        /// </param>
        /// <param name="requestId">
        /// Unique request ID.
        /// </param>
        public ErrorResponse(
            int? code,
            string? message,
            string? requestId)
        {
            this.Code = code;
            this.Message = message;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}