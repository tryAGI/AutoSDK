//HintName: G.Models.BatchMessageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An individual message request within a batch.
    /// </summary>
    public sealed partial class BatchMessageRequest
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for<br/>
        /// matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// The request parameters for creating a message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateMessageRequest Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessageRequest" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for<br/>
        /// matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </param>
        /// <param name="params">
        /// The request parameters for creating a message.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchMessageRequest(
            string customId,
            global::G.CreateMessageRequest @params)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessageRequest" /> class.
        /// </summary>
        public BatchMessageRequest()
        {
        }
    }
}