//HintName: G.Models.CreateMessageBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request parameters for creating a message batch.
    /// </summary>
    public sealed partial class CreateMessageBatchRequest
    {
        /// <summary>
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BatchMessageRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageBatchRequest" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateMessageBatchRequest(
            global::System.Collections.Generic.IList<global::G.BatchMessageRequest> requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageBatchRequest" /> class.
        /// </summary>
        public CreateMessageBatchRequest()
        {
        }
    }
}