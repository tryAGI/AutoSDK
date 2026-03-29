//HintName: G.Models.CreatePromptCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptCompletionResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Response headers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.OneOf<global::G.CreateChatCompletionResponse, global::G.CreateCompletionResponse>? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptCompletionResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Response status
        /// </param>
        /// <param name="headers">
        /// Response headers
        /// </param>
        /// <param name="body"></param>
        public CreatePromptCompletionResponse(
            string? status,
            object? headers,
            global::G.OneOf<global::G.CreateChatCompletionResponse, global::G.CreateCompletionResponse>? body)
        {
            this.Status = status;
            this.Headers = headers;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptCompletionResponse" /> class.
        /// </summary>
        public CreatePromptCompletionResponse()
        {
        }
    }
}