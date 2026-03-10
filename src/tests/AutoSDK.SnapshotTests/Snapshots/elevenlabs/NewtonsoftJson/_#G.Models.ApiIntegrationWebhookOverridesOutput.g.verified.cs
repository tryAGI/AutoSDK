//HintName: G.Models.ApiIntegrationWebhookOverridesOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A whitelist of fields that can be overridden by users when<br/>
    /// configuring an API Integration Webhook Tool.
    /// </summary>
    public sealed partial class ApiIntegrationWebhookOverridesOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_overrides")]
        public object? SchemaOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LiteralOverride>? PathParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_params_schema")]
        public global::G.QueryOverride? QueryParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body_schema")]
        public global::G.ObjectOverrideOutput? RequestBodySchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_filter_mode")]
        public global::G.ResponseFilterMode? ResponseFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_filters")]
        public global::System.Collections.Generic.IList<string>? ResponseFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverridesOutput" /> class.
        /// </summary>
        /// <param name="schemaOverrides"></param>
        /// <param name="pathParamsSchema"></param>
        /// <param name="queryParamsSchema"></param>
        /// <param name="requestBodySchema"></param>
        /// <param name="requestHeaders"></param>
        /// <param name="responseFilterMode"></param>
        /// <param name="responseFilters"></param>
        public ApiIntegrationWebhookOverridesOutput(
            object? schemaOverrides,
            global::System.Collections.Generic.Dictionary<string, global::G.LiteralOverride>? pathParamsSchema,
            global::G.QueryOverride? queryParamsSchema,
            global::G.ObjectOverrideOutput? requestBodySchema,
            object? requestHeaders,
            global::G.ResponseFilterMode? responseFilterMode,
            global::System.Collections.Generic.IList<string>? responseFilters)
        {
            this.SchemaOverrides = schemaOverrides;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
            this.ResponseFilterMode = responseFilterMode;
            this.ResponseFilters = responseFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverridesOutput" /> class.
        /// </summary>
        public ApiIntegrationWebhookOverridesOutput()
        {
        }
    }
}