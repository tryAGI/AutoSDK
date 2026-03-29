//HintName: G.Models.InlinedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a single request in the batch.
    /// </summary>
    public sealed partial class InlinedResponse
    {
        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.Status? Error { get; set; }

        /// <summary>
        /// Response from the model supporting multiple candidate responses. Safety ratings and content filtering are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API: - Returns either all requested candidates or none of them - Returns no candidates at all only if there was something wrong with the prompt (check `prompt_feedback`) - Reports feedback on each candidate in `finish_reason` and `safety_ratings`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.GenerateContentResponse? Response { get; set; }

        /// <summary>
        /// Output only. The metadata associated with the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
        /// <param name="response">
        /// Response from the model supporting multiple candidate responses. Safety ratings and content filtering are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API: - Returns either all requested candidates or none of them - Returns no candidates at all only if there was something wrong with the prompt (check `prompt_feedback`) - Reports feedback on each candidate in `finish_reason` and `safety_ratings`.
        /// </param>
        /// <param name="metadata">
        /// Output only. The metadata associated with the request.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlinedResponse(
            global::G.Status? error,
            global::G.GenerateContentResponse? response,
            object? metadata)
        {
            this.Error = error;
            this.Response = response;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedResponse" /> class.
        /// </summary>
        public InlinedResponse()
        {
        }
    }
}