//HintName: G.Models.DeleteComputeInstanceResponseError4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details
    /// </summary>
    public sealed partial class DeleteComputeInstanceResponseError4
    {
        /// <summary>
        /// The category of error that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteComputeInstanceResponseErrorType4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteComputeInstanceResponseErrorType4 Type { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Link to relevant documentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs_url")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// Unique request identifier for debugging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteComputeInstanceResponseError4" /> class.
        /// </summary>
        /// <param name="type">
        /// The category of error that occurred
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="docsUrl">
        /// Link to relevant documentation
        /// </param>
        /// <param name="requestId">
        /// Unique request identifier for debugging
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteComputeInstanceResponseError4(
            global::G.DeleteComputeInstanceResponseErrorType4 type,
            string message,
            string? docsUrl,
            string? requestId)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DocsUrl = docsUrl;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteComputeInstanceResponseError4" /> class.
        /// </summary>
        public DeleteComputeInstanceResponseError4()
        {
        }
    }
}