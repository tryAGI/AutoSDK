//HintName: G.Models.ResponsesResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesResponse200
    {
        /// <summary>
        /// Unique ID for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (chat completion).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the chat completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// The status of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The max_tool_calls specified in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// The chat model used for generating completions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of result outputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::System.Collections.Generic.IList<global::G.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems>? Output { get; set; }

        /// <summary>
        /// The instructions entered in the request input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The max_output_tokens value entered in the request input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// The parallel_tool_calls value entered in the request input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public int? ParallelToolCalls { get; set; }

        /// <summary>
        /// The temperature value entered in the request input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the chat completion.
        /// </param>
        /// <param name="object">
        /// Type of object (chat completion).
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the chat completion was created.
        /// </param>
        /// <param name="status">
        /// The status of the request.
        /// </param>
        /// <param name="maxToolCalls">
        /// The max_tool_calls specified in the request.
        /// </param>
        /// <param name="model">
        /// The chat model used for generating completions.
        /// </param>
        /// <param name="output">
        /// The set of result outputs.
        /// </param>
        /// <param name="instructions">
        /// The instructions entered in the request input.
        /// </param>
        /// <param name="maxOutputTokens">
        /// The max_output_tokens value entered in the request input.
        /// </param>
        /// <param name="parallelToolCalls">
        /// The parallel_tool_calls value entered in the request input.
        /// </param>
        /// <param name="temperature">
        /// The temperature value entered in the request input.
        /// </param>
        public ResponsesResponse200(
            string? id,
            string? @object,
            int? createdAt,
            string? status,
            int? maxToolCalls,
            string? model,
            global::System.Collections.Generic.IList<global::G.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems>? output,
            string? instructions,
            int? maxOutputTokens,
            int? parallelToolCalls,
            double? temperature)
        {
            this.Id = id;
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Output = output;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse200" /> class.
        /// </summary>
        public ResponsesResponse200()
        {
        }
    }
}