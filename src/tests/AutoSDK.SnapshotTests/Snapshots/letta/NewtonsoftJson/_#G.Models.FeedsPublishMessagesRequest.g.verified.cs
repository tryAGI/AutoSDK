//HintName: G.Models.FeedsPublishMessagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsPublishMessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedsPublishMessagesRequestMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsPublishMessagesRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        public FeedsPublishMessagesRequest(
            global::System.Collections.Generic.IList<global::G.FeedsPublishMessagesRequestMessage> messages)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsPublishMessagesRequest" /> class.
        /// </summary>
        public FeedsPublishMessagesRequest()
        {
        }
    }
}