//HintName: G.Models.ServerlessGetAppQueueInfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the app queue
    /// </summary>
    public sealed partial class ServerlessGetAppQueueInfoResponse
    {
        /// <summary>
        /// Current number of requests in the queue<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueueSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAppQueueInfoResponse" /> class.
        /// </summary>
        /// <param name="queueSize">
        /// Current number of requests in the queue<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetAppQueueInfoResponse(
            int queueSize)
        {
            this.QueueSize = queueSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAppQueueInfoResponse" /> class.
        /// </summary>
        public ServerlessGetAppQueueInfoResponse()
        {
        }
    }
}