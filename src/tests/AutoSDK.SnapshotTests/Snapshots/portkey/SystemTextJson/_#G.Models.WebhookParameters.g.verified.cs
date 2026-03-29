//HintName: G.Models.WebhookParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookParameters
    {
        /// <summary>
        /// Webhook URL to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookURL { get; set; }

        /// <summary>
        /// Headers to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Fail if webhook returns non-200 status or times out<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failOnError")]
        public bool? FailOnError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookParameters" /> class.
        /// </summary>
        /// <param name="webhookURL">
        /// Webhook URL to call
        /// </param>
        /// <param name="headers">
        /// Headers to send with the request
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="failOnError">
        /// Fail if webhook returns non-200 status or times out<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookParameters(
            string webhookURL,
            object? headers,
            double? timeout,
            bool? failOnError)
        {
            this.WebhookURL = webhookURL ?? throw new global::System.ArgumentNullException(nameof(webhookURL));
            this.Headers = headers;
            this.Timeout = timeout;
            this.FailOnError = failOnError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookParameters" /> class.
        /// </summary>
        public WebhookParameters()
        {
        }
    }
}