//HintName: G.Models.ReturnEventMessageSpecs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnEventMessageSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_new_chat")]
        public global::G.ReturnEventMessageSpec? OnNewChat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_inactivity_timeout")]
        public global::G.ReturnEventMessageSpec? OnInactivityTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_max_duration_timeout")]
        public global::G.ReturnEventMessageSpec? OnMaxDurationTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEventMessageSpecs" /> class.
        /// </summary>
        /// <param name="onNewChat"></param>
        /// <param name="onInactivityTimeout"></param>
        /// <param name="onMaxDurationTimeout"></param>
        public ReturnEventMessageSpecs(
            global::G.ReturnEventMessageSpec? onNewChat,
            global::G.ReturnEventMessageSpec? onInactivityTimeout,
            global::G.ReturnEventMessageSpec? onMaxDurationTimeout)
        {
            this.OnNewChat = onNewChat;
            this.OnInactivityTimeout = onInactivityTimeout;
            this.OnMaxDurationTimeout = onMaxDurationTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEventMessageSpecs" /> class.
        /// </summary>
        public ReturnEventMessageSpecs()
        {
        }
    }
}