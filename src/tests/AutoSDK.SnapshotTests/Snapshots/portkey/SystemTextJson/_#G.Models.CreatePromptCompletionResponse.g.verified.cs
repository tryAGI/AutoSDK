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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Response headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateChatCompletionResponse, global::G.CreateCompletionResponse>))]
        public global::G.OneOf<global::G.CreateChatCompletionResponse, global::G.CreateCompletionResponse>? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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