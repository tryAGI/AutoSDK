//HintName: G.Models.TestWebhookResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from webhook test
    /// </summary>
    public sealed partial class TestWebhookResponseDto
    {
        /// <summary>
        /// Whether the webhook call succeeded (2xx status code)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// HTTP status code returned by the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// Response data from the webhook (if successful)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_data")]
        public object? ResponseData { get; set; }

        /// <summary>
        /// Error message (if failed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TriggerEventData RequestPayload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestWebhookResponseDto" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the webhook call succeeded (2xx status code)
        /// </param>
        /// <param name="requestPayload"></param>
        /// <param name="statusCode">
        /// HTTP status code returned by the webhook
        /// </param>
        /// <param name="responseData">
        /// Response data from the webhook (if successful)
        /// </param>
        /// <param name="errorMessage">
        /// Error message (if failed)
        /// </param>
        public TestWebhookResponseDto(
            bool success,
            global::G.TriggerEventData requestPayload,
            double? statusCode,
            object? responseData,
            string? errorMessage)
        {
            this.Success = success;
            this.StatusCode = statusCode;
            this.ResponseData = responseData;
            this.ErrorMessage = errorMessage;
            this.RequestPayload = requestPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestWebhookResponseDto" /> class.
        /// </summary>
        public TestWebhookResponseDto()
        {
        }
    }
}