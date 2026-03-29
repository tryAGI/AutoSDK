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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_sent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MessagesSent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsTriggerSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="messagesSent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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