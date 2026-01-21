//HintName: G.Models.ConversationHistoryTranscriptToolCallWebhookDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallWebhookDetails
    {
        /// <summary>
        /// Default Value: webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("path_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? PathParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? QueryParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallWebhookDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: webhook
        /// </param>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="pathParams"></param>
        /// <param name="queryParams"></param>
        /// <param name="body"></param>
        public ConversationHistoryTranscriptToolCallWebhookDetails(
            string method,
            string url,
            string? type,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? pathParams,
            global::System.Collections.Generic.Dictionary<string, string>? queryParams,
            string? body)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
            this.Headers = headers;
            this.PathParams = pathParams;
            this.QueryParams = queryParams;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallWebhookDetails" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallWebhookDetails()
        {
        }
    }
}