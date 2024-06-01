//HintName: G.Models.ActivitySetRepoSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitySetRepoSubscriptionRequest
    {
        /// <summary>
        /// Determines if notifications should be received from this repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        /// <summary>
        /// Determines if all notifications should be blocked from this repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignored")]
        public bool Ignored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}