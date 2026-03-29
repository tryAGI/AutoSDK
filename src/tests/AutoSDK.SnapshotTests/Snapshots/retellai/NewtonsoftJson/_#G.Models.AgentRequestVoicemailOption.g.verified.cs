//HintName: G.Models.AgentRequestVoicemailOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If this option is set, the call will try to detect voicemail in the first 3 minutes of the call. Actions defined (hangup, or leave a message) will be applied when the voicemail is detected. Set this to null to disable voicemail detection.<br/>
    /// Example: {"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}
    /// </summary>
    public sealed partial class AgentRequestVoicemailOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoicemailAction Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        /// <param name="action"></param>
        public AgentRequestVoicemailOption(
            global::G.VoicemailAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        public AgentRequestVoicemailOption()
        {
        }
    }
}