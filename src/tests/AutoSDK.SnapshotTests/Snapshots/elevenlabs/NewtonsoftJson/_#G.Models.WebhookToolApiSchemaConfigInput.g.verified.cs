//HintName: G.Models.WebhookToolApiSchemaConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a webhook that will be called by an LLM tool.<br/>
    /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigInput
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
        public global::G.WebhookToolApiSchemaConfigInputMethod? Method { get; set; }

        /// <summary>
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? PathParamsSchema { get; set; }

        /// <summary>
        /// Schema for any query params, if any. These will be added to end of the URL as query params. Note: properties in a query param must all be literal types
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_params_schema")]
        public global::G.QueryParamsJsonSchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// Schema for the body parameters, if any. Used for POST/PATCH/PUT requests. The schema should be an object which will be sent as the json body
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body_schema")]
        public global::G.ObjectJsonSchemaPropertyInput? RequestBodySchema { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigInput" /> class.
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
        /// <param name="queryParamsSchema">
        /// Schema for any query params, if any. These will be added to end of the URL as query params. Note: properties in a query param must all be literal types
        /// </param>
        /// <param name="requestBodySchema">
        /// Schema for the body parameters, if any. Used for POST/PATCH/PUT requests. The schema should be an object which will be sent as the json body
        /// </param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
        public WebhookToolApiSchemaConfigInput(
            string url,
            global::G.WebhookToolApiSchemaConfigInputMethod? method,
            global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? pathParamsSchema,
            global::G.QueryParamsJsonSchema? queryParamsSchema,
            global::G.ObjectJsonSchemaPropertyInput? requestBodySchema,
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
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigInput" /> class.
        /// </summary>
        public WebhookToolApiSchemaConfigInput()
        {
        }
    }
}