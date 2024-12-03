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
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribed")]
        public bool? Subscribed { get; set; }

        /// <summary>
        /// Determines if all notifications should be blocked from this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySetRepoSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="subscribed">
        /// Determines if notifications should be received from this repository.
        /// </param>
        /// <param name="ignored">
        /// Determines if all notifications should be blocked from this repository.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActivitySetRepoSubscriptionRequest(
            bool? subscribed,
            bool? ignored)
        {
            this.Subscribed = subscribed;
            this.Ignored = ignored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySetRepoSubscriptionRequest" /> class.
        /// </summary>
        public ActivitySetRepoSubscriptionRequest()
        {
        }
    }
}