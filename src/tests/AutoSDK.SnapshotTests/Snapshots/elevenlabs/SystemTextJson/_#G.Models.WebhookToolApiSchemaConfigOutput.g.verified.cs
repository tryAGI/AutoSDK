//HintName: G.Models.WebhookToolApiSchemaConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a webhook that will be called by an LLM tool.<br/>
    /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigOutput
    {
        /// <summary>
        /// The URL that the webhook will be sent to. May include path parameters, e.g. https://example.com/agents/{agent_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The HTTP method to use for the webhook<br/>
        /// Default Value: GET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter))]
        public global::G.WebhookToolApiSchemaConfigOutputMethod? Method { get; set; }

        /// <summary>
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralJsonSchemaProperty>? PathParamsSchema { get; set; }

        /// <summary>
        /// Schema for any query params, if any. These will be added to end of the URL as query params. Note: properties in a query param must all be literal types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params_schema")]
        public global::G.QueryParamsJsonSchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// Schema for the body parameters, if any. Used for POST/PATCH/PUT requests. The schema should be an object which will be sent as the json body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body_schema")]
        public global::G.ObjectJsonSchemaPropertyOutput? RequestBodySchema { get; set; }

        /// <summary>
        /// Headers that should be included in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="queryParamsSchema">
        /// Schema for any query params, if any. These will be added to end of the URL as query params. Note: properties in a query param must all be literal types
        /// </param>
        /// <param name="requestBodySchema">
        /// Schema for the body parameters, if any. Used for POST/PATCH/PUT requests. The schema should be an object which will be sent as the json body
        /// </param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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