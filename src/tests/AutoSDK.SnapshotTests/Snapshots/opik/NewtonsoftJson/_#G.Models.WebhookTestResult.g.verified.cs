//HintName: G.Models.WebhookTestResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTestResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookTestResultStatusJsonConverter))]
        public global::G.WebhookTestResultStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTestResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statusCode"></param>
        /// <param name="requestBody"></param>
        /// <param name="errorMessage"></param>
        public WebhookTestResult(
            global::G.WebhookTestResultStatus? status,
            int? statusCode,
            string? requestBody,
            string? errorMessage)
        {
            this.Status = status;
            this.StatusCode = statusCode;
            this.RequestBody = requestBody;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTestResult" /> class.
        /// </summary>
        public WebhookTestResult()
        {
        }
    }
}