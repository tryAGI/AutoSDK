//HintName: G.Models.InlinedEmbedContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a single request in the batch.
    /// </summary>
    public sealed partial class InlinedEmbedContentResponse
    {
        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.Status? Error { get; set; }

        /// <summary>
        /// The response to an `EmbedContentRequest`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.EmbedContentResponse? Response { get; set; }

        /// <summary>
        /// Output only. The metadata associated with the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
        /// <param name="response">
        /// The response to an `EmbedContentRequest`.
        /// </param>
        /// <param name="metadata">
        /// Output only. The metadata associated with the request.<br/>
        /// Included only in responses
        /// </param>
        public InlinedEmbedContentResponse(
            global::G.Status? error,
            global::G.EmbedContentResponse? response,
            object? metadata)
        {
            this.Error = error;
            this.Response = response;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentResponse" /> class.
        /// </summary>
        public InlinedEmbedContentResponse()
        {
        }
    }
}