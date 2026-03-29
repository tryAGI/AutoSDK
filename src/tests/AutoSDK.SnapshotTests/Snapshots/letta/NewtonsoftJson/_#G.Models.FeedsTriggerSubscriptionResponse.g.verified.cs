//HintName: G.Models.FeedsTriggerSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsTriggerSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages_sent", Required = global::Newtonsoft.Json.Required.Always)]
        public double MessagesSent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsTriggerSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="messagesSent"></param>
        public FeedsTriggerSubscriptionResponse(
            bool success,
            double messagesSent)
        {
            this.Success = success;
            this.MessagesSent = messagesSent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsTriggerSubscriptionResponse" /> class.
        /// </summary>
        public FeedsTriggerSubscriptionResponse()
        {
        }
    }
}