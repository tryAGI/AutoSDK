//HintName: G.Models.GetAnalyticsResponseError4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details
    /// </summary>
    public sealed partial class GetAnalyticsResponseError4
    {
        /// <summary>
        /// The category of error that occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAnalyticsResponseErrorType4 Type { get; set; } = default!;

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Link to relevant documentation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docs_url")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// Unique request identifier for debugging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponseError4" /> class.
        /// </summary>
        /// <param name="type">
        /// The category of error that occurred
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="docsUrl">
        /// Link to relevant documentation
        /// </param>
        /// <param name="requestId">
        /// Unique request identifier for debugging
        /// </param>
        public GetAnalyticsResponseError4(
            global::G.GetAnalyticsResponseErrorType4 type,
            string message,
            string? docsUrl,
            string? requestId)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DocsUrl = docsUrl;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponseError4" /> class.
        /// </summary>
        public GetAnalyticsResponseError4()
        {
        }
    }
}