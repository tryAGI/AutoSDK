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
        [global::Newtonsoft.Json.JsonProperty("queue_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int QueueSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAppQueueInfoResponse" /> class.
        /// </summary>
        /// <param name="queueSize">
        /// Current number of requests in the queue<br/>
        /// Example: 5
        /// </param>
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