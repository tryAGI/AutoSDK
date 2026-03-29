//HintName: G.Models.InlinedEmbedContentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request to be processed in the batch.
    /// </summary>
    public sealed partial class InlinedEmbedContentRequest
    {
        /// <summary>
        /// Request containing the `Content` for the model to embed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.EmbedContentRequest? Request { get; set; }

        /// <summary>
        /// Optional. The metadata to be associated with the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequest" /> class.
        /// </summary>
        /// <param name="request">
        /// Request containing the `Content` for the model to embed.
        /// </param>
        /// <param name="metadata">
        /// Optional. The metadata to be associated with the request.
        /// </param>
        public InlinedEmbedContentRequest(
            global::G.EmbedContentRequest? request,
            object? metadata)
        {
            this.Request = request;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequest" /> class.
        /// </summary>
        public InlinedEmbedContentRequest()
        {
        }
    }
}