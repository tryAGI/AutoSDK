//HintName: G.Models.PostedEventMessageSpecs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedEventMessageSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_new_chat")]
        public global::G.PostedEventMessageSpec? OnNewChat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_inactivity_timeout")]
        public global::G.PostedEventMessageSpec? OnInactivityTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_max_duration_timeout")]
        public global::G.PostedEventMessageSpec? OnMaxDurationTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEventMessageSpecs" /> class.
        /// </summary>
        /// <param name="onNewChat"></param>
        /// <param name="onInactivityTimeout"></param>
        /// <param name="onMaxDurationTimeout"></param>
        public PostedEventMessageSpecs(
            global::G.PostedEventMessageSpec? onNewChat,
            global::G.PostedEventMessageSpec? onInactivityTimeout,
            global::G.PostedEventMessageSpec? onMaxDurationTimeout)
        {
            this.OnNewChat = onNewChat;
            this.OnInactivityTimeout = onInactivityTimeout;
            this.OnMaxDurationTimeout = onMaxDurationTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEventMessageSpecs" /> class.
        /// </summary>
        public PostedEventMessageSpecs()
        {
        }
    }
}