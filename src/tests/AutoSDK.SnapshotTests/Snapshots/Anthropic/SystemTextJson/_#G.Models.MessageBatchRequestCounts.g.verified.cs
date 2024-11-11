//HintName: G.Models.MessageBatchRequestCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tallies requests within the Message Batch, categorized by their status.
    /// </summary>
    public sealed partial class MessageBatchRequestCounts
    {
        /// <summary>
        /// Number of requests in the Message Batch that are processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processing { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Succeeded { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errored { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Canceled { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchRequestCounts" /> class.
        /// </summary>
        /// <param name="processing">
        /// Number of requests in the Message Batch that are processing.
        /// </param>
        /// <param name="succeeded">
        /// Number of requests in the Message Batch that have completed successfully.
        /// </param>
        /// <param name="errored">
        /// Number of requests in the Message Batch that encountered an error.
        /// </param>
        /// <param name="canceled">
        /// Number of requests in the Message Batch that have been canceled.
        /// </param>
        /// <param name="expired">
        /// Number of requests in the Message Batch that have expired.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageBatchRequestCounts(
            int processing,
            int succeeded,
            int errored,
            int canceled,
            int expired)
        {
            this.Processing = processing;
            this.Succeeded = succeeded;
            this.Errored = errored;
            this.Canceled = canceled;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchRequestCounts" /> class.
        /// </summary>
        public MessageBatchRequestCounts()
        {
        }
    }
}