//HintName: G.Models.ErrorDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorDetail
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Error description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ErrorDetailCodeJsonConverter))]
        public global::G.ErrorDetailCode? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="message">
        /// Error description
        /// </param>
        /// <param name="code">
        /// Error code
        /// </param>
        public ErrorDetail(
            string? requestId,
            string? message,
            global::G.ErrorDetailCode? code)
        {
            this.RequestId = requestId;
            this.Message = message;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        public ErrorDetail()
        {
        }
    }
}