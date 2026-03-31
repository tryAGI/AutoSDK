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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// HTTP status code returned by the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// Response data from the webhook (if successful)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_data")]
        public object? ResponseData { get; set; }

        /// <summary>
        /// Error message (if failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TriggerEventDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TriggerEventData RequestPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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