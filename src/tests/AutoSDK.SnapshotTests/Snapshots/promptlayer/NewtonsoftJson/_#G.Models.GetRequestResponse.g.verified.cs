//HintName: G.Models.GetRequestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRequestResponse
    {
        /// <summary>
        /// Indicates the request was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// The request converted to a prompt blueprint format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_blueprint")]
        public global::G.GetRequestResponsePromptBlueprint? PromptBlueprint { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public int? RequestId { get; set; }

        /// <summary>
        /// The LLM provider (e.g. openai, anthropic).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The model name (e.g. gpt-4, claude-3-sonnet).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Number of input tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Number of output tokens generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Total token count (input + output).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// Cost of the request in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the request started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_start_time")]
        public string? RequestStartTime { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the request ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_end_time")]
        public string? RequestEndTime { get; set; }

        /// <summary>
        /// Request latency in milliseconds, derived from start and end times.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_ms")]
        public double? LatencyMs { get; set; }

        /// <summary>
        /// The trace ID associated with this request, if the request was part of a trace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates the request was successful.
        /// </param>
        /// <param name="promptBlueprint">
        /// The request converted to a prompt blueprint format.
        /// </param>
        /// <param name="requestId">
        /// The ID of the request.
        /// </param>
        /// <param name="provider">
        /// The LLM provider (e.g. openai, anthropic).
        /// </param>
        /// <param name="model">
        /// The model name (e.g. gpt-4, claude-3-sonnet).
        /// </param>
        /// <param name="inputTokens">
        /// Number of input tokens used.
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens generated.
        /// </param>
        /// <param name="tokens">
        /// Total token count (input + output).
        /// </param>
        /// <param name="price">
        /// Cost of the request in USD.
        /// </param>
        /// <param name="requestStartTime">
        /// ISO 8601 timestamp of when the request started.
        /// </param>
        /// <param name="requestEndTime">
        /// ISO 8601 timestamp of when the request ended.
        /// </param>
        /// <param name="latencyMs">
        /// Request latency in milliseconds, derived from start and end times.
        /// </param>
        /// <param name="traceId">
        /// The trace ID associated with this request, if the request was part of a trace.
        /// </param>
        public GetRequestResponse(
            bool? success,
            global::G.GetRequestResponsePromptBlueprint? promptBlueprint,
            int? requestId,
            string? provider,
            string? model,
            int? inputTokens,
            int? outputTokens,
            int? tokens,
            double? price,
            string? requestStartTime,
            string? requestEndTime,
            double? latencyMs,
            string? traceId)
        {
            this.Success = success;
            this.PromptBlueprint = promptBlueprint;
            this.RequestId = requestId;
            this.Provider = provider;
            this.Model = model;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Tokens = tokens;
            this.Price = price;
            this.RequestStartTime = requestStartTime;
            this.RequestEndTime = requestEndTime;
            this.LatencyMs = latencyMs;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponse" /> class.
        /// </summary>
        public GetRequestResponse()
        {
        }
    }
}