//HintName: G.Models.NonStreamAnalyzeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When the value of the `stream` parameter is set to `false`, the response is as follows:
    /// </summary>
    public sealed partial class NonStreamAnalyzeResponse
    {
        /// <summary>
        /// Unique identifier of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The generated text based on the prompt you provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// The number of tokens used in the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.TokenUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamAnalyzeResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the response.
        /// </param>
        /// <param name="data">
        /// The generated text based on the prompt you provided.
        /// </param>
        /// <param name="finishReason">
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="usage">
        /// The number of tokens used in the generation.
        /// </param>
        public NonStreamAnalyzeResponse(
            string? id,
            string? data,
            global::G.FinishReason? finishReason,
            global::G.TokenUsage? usage)
        {
            this.Id = id;
            this.Data = data;
            this.FinishReason = finishReason;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamAnalyzeResponse" /> class.
        /// </summary>
        public NonStreamAnalyzeResponse()
        {
        }
    }
}