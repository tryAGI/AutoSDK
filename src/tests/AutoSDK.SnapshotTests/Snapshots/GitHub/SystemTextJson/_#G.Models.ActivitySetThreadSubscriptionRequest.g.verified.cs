//HintName: G.Models.ActivitySetThreadSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitySetThreadSubscriptionRequest
    {
        /// <summary>
        /// Whether to block all notifications from a thread.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySetThreadSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="ignored">
        /// Whether to block all notifications from a thread.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActivitySetThreadSubscriptionRequest(
            bool? ignored)
        {
            this.Ignored = ignored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySetThreadSubscriptionRequest" /> class.
        /// </summary>
        public ActivitySetThreadSubscriptionRequest()
        {
        }
    }
}