//HintName: G.Models.WebhookToolApiSchemaConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a webhook that will be called by an LLM tool.
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigOutput
    {
        /// <summary>
        /// The URL that the webhook will be sent to. May include path parameters, e.g. https://example.com/agents/{agent_id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The HTTP method to use for the webhook<br/>
        /// Default Value: GET
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.WebhookToolApiSchemaConfigOutputMethod? Method { get; set; }

        /// <summary>
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? PathParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_params_schema")]
        public global::G.QueryParamsJsonSchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body_schema")]
        public global::G.ObjectJsonSchemaPropertyOutput? RequestBodySchema { get; set; }

        /// <summary>
        /// Headers that should be included in the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigOutput" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL that the webhook will be sent to. May include path parameters, e.g. https://example.com/agents/{agent_id}
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the webhook<br/>
        /// Default Value: GET
        /// </param>
        /// <param name="pathParamsSchema">
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </param>
        /// <param name="queryParamsSchema"></param>
        /// <param name="requestBodySchema"></param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
        public WebhookToolApiSchemaConfigOutput(
            string url,
            global::G.WebhookToolApiSchemaConfigOutputMethod? method,
            global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? pathParamsSchema,
            global::G.QueryParamsJsonSchema? queryParamsSchema,
            global::G.ObjectJsonSchemaPropertyOutput? requestBodySchema,
            object? requestHeaders)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigOutput" /> class.
        /// </summary>
        public WebhookToolApiSchemaConfigOutput()
        {
        }
    }
}